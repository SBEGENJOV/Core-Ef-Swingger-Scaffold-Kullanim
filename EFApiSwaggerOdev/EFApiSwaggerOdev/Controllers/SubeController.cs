using EFApiSwaggerOdev.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace EFApiSwaggerOdev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubeController : ControllerBase
    {
        public readonly MarketlerSwaggerApiDbContext Context;
        public SubeController(MarketlerSwaggerApiDbContext context)
        {
            this.Context = context;
        }
        [HttpGet]
        [Route("GetSube")]
        public async Task<IEnumerable> GetSube()
        {
            return await Context.Subes.ToListAsync();
        }
        [HttpPost]
        [Route("GetSubeAdd")]
        public async Task<Sube> GetSubeAdd(Sube sube)
        {
            Context.Add(sube);
             Context.SaveChanges();
            return sube;
        }
        [HttpPut]
        [Route("GetSubeEdit/id")]
        public async Task<Sube> GetSubeEdit (Sube sube)
        {
            Context.Update(sube);
            Context.SaveChanges();
            return sube;
        }
        [HttpDelete]
        [Route("GetSubeDelete/id")]
        public async Task<Sube> GetSubeDelete(int id,Sube sube)
        {
            Context.Remove(Context.Subes.Find(id));
            Context.SaveChanges();
            return sube;
        }
    }
}
