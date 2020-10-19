using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Database;
using Backend.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.IO;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.AspNetCore.Hosting;
using System.ComponentModel;

namespace Backend.Controllers
{
    [ApiController]
    [Route("games")]
    public class GameInfoController : ControllerBase
    {

        private readonly IGameRepository gameRepository;
        private readonly IImageRepository imageRepository;
        private readonly IWebHostEnvironment env;
        
        /**
        * To use IGameRepository, we need to tell dotnet to use dependency injection
        * to inject the repositories we need. 
        * just like we inject IWebHostEnvironment IHostEnv in the constructor right now.
        */
        public GameInfoController(IWebHostEnvironment IHostEnv)
        {
            env = IHostEnv;
        }

        //IGameRepository is a repo to handle game information,
        //The usual CRUD operations is awailable

        //IImageRepository is a repo to handle upload and fetching
        //image from the api.

        //To recieve a image from post we can use FromForm
        //PostGameImage is defined in Models/GameInfo.cs
        // public async Task<GameInfo> AddGameWithImage([FromForm] PostGameImage GameInfo)
        // {
        // }
        
        //To send a image as response we can return a PhysicaFile
        // public async Task<IActionResult> GetImage(int Id)
        // {
        //     return PhysicalFile(k.ImgSrc, k.ImgType);
        // }
    }
}
