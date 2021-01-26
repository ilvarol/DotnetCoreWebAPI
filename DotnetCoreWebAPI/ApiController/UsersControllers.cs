using AutoMapper;
using DotnetCoreWebAPI.Data;
using DotnetCoreWebAPI.Dtos;
using DotnetCoreWebAPI.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace DotnetCoreWebAPI.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepo _repository;
        private readonly IMapper _mapper;

        public UsersController(IUserRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/users
        [HttpGet]
        public ActionResult<IEnumerable<UserReadDto>> GetAllUsers()
        {
            var userItems = _repository.GetAllUsers();

            return Ok(_mapper.Map<IEnumerable<UserReadDto>>(userItems));
        }

        //GET api/users/{id}
        [HttpGet("{id}", Name = "GetUserById")]
        public ActionResult<UserReadDto> GetUserById(int id)
        {
            var user = _repository.GetUserById(id);
            if (user != null)
                return Ok(_mapper.Map<UserReadDto>(user));
            else
                return NotFound();
        }

        //POST api/users
        [HttpPost]
        public ActionResult<UserReadDto> CreateUser([FromForm] UserCreateDto userCreateDto)
        {
            var userModel = _mapper.Map<User>(userCreateDto);
            _repository.CreateUser(userModel);
            _repository.SaveChanges();

            var userReadDto = _mapper.Map<UserReadDto>(userModel);

            return CreatedAtRoute(nameof(GetUserById), new { Id = userReadDto.Id }, userReadDto);
        }

        //PUT api/users/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateUser(int id, UserUpdateDto userUpdateDto)
        {
            var userModelFromRepo = _repository.GetUserById(id);
            if (userModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(userUpdateDto, userModelFromRepo);

            _repository.UpdateUser(userModelFromRepo);
            _repository.SaveChanges();

            return NoContent();

        }

        //PATCH api/users/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialUserUpdate(int id, JsonPatchDocument<UserUpdateDto> patchDoc)
        {
            var userModelFromRepo = _repository.GetUserById(id);
            if (userModelFromRepo == null)
            {
                return NotFound();
            }

            var userToPatch = _mapper.Map<UserUpdateDto>(userModelFromRepo);
            patchDoc.ApplyTo(userToPatch, ModelState);
            if (!TryValidateModel(userToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(userToPatch, userModelFromRepo);

            _repository.UpdateUser(userModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

        //DELETE api/users/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteUser(int id)
        {
            var user = _repository.GetUserById(id);
            if (user != null)
            {
                _repository.DeleteUser(user);
                _repository.SaveChanges();

                return NoContent();
            }
            else
                return NotFound();
        }
    }
}
