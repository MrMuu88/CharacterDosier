using CharacterDosier.API.ViewModels;
using CharacterDosier.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CharacterDosier.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CharacterController : ControllerBase
	{
		[HttpGet("{id}")]
		public Task<ActionResult<Character>> get(int id) {

			//TODO Implement
			throw new NotImplementedException();
		}

		[HttpGet]
		public Task<ActionResult<CharacterListResponse>> List() {

			//TODO Implement
			throw new NotImplementedException();
		}
	}
}
namespace CharacterDosier.API.ViewModels
{
	public class CharacterListResponse { 
		public int Id { get; set; }
		public string Name { get; set; }
		public int Level { get; set; }
		public string Race { get; set; }
		public string Class { get; set; }
	}
}
