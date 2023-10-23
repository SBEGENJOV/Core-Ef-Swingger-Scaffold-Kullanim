using EFApiSwaggerOdev.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace EFApiSwaggerOdev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarketController : ControllerBase
    {
        public readonly MarketlerSwaggerApiDbContext Context;
        public MarketController(MarketlerSwaggerApiDbContext context)
        {
            this.Context = context;
        }
        [HttpGet]
        [Route("GetMarket")]
        public async Task<IEnumerable> GetMarket()
        {
            
            return await Context.Markets.ToListAsync();
        }
        [HttpPost]
        [Route("GetMarketAdd")]
        public async Task<Market> GetMarketAdd(Market market)
        {
            Context.Markets.Add(market);
            Context.SaveChanges();
            return market;
        }
        [HttpPut]
        [Route("GetMarketEdit/id")]
        public async Task<Market> GetMarketEdit(Market market)
        {
            Context.Update(market);
            Context.SaveChanges();
            return market;
        }
        [HttpDelete]
        [Route("GetMarketDelete/id")]
        public async Task<Market> GetMarketDelete(int id,Market market)
        {
            Context.Remove(Context.Markets.Find(id));
            Context.SaveChanges();
            return market;
        }
    }
}
