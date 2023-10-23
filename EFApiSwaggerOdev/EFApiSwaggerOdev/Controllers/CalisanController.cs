using EFApiSwaggerOdev.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace EFApiSwaggerOdev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalisanController : ControllerBase
    {
        public readonly MarketlerSwaggerApiDbContext Context;
        public CalisanController(MarketlerSwaggerApiDbContext context)
        {
            this.Context = context;
        }
        [HttpGet]
        [Route("GetCalisan")]
        public async Task<IEnumerable> GetCalisan()
        {
            return await Context.Calisans.ToListAsync();
        }
        [HttpPost]
        [Route("GetCalisanAdd")]
        public async Task<Calisan> GetCalisanAdd(Calisan calisan)
        {
            Context.Add(calisan);
            Context.SaveChanges();
            return calisan;
        }
        [HttpPut]
        [Route("GetCalisanEdit/id")]
        public async Task<Calisan> GetCalisanEdit(Calisan calisan)
        {
            Context.Update(calisan);
            Context.SaveChanges();
            return calisan;
        }
        [HttpDelete]
        [Route("GetCalisanDelete/id")]
        public async Task<Calisan> GetCalisanDelete(int id,Calisan calisan)
        {
            Context.Remove(Context.Calisans.Find(id));
            Context.SaveChanges();
            return calisan;
        }
    }
}
