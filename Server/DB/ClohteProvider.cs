using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using BuyStarOn.Server.Controllers;
using BuyStarOn.Shared;
using Microsoft.EntityFrameworkCore;


namespace BuyStarOn.Server.DB
{
    public class ClotheProvider
    {
        //*********************Yek object az class ClotheDBContext
        private readonly ClotheDBContext _context;
        private readonly ILogger _logger;
        public ClotheProvider(ClotheDBContext context, ILoggerFactory loggerFactory)
        {
            this._context = context;
            this._logger = loggerFactory.CreateLogger("ClotheProvider");
        }
        public async Task AddClothe(Articles clothe)
        {
            var LastClothe = this._context.Clothes.ToArray().LastOrDefault();
            var LastId = this._context.Clothes.Select( c => c.Id).Max();
            var newID = 0;
            if(!(LastClothe is null))
                newID = LastId+ 1;
            clothe.Id = newID;

            await _context.Clothes.AddAsync(clothe);
            await _context.SaveChangesAsync();
        }

        // public async Task RemoveClothe(int ids)
        // {
        //     var clothe = _context.Clothes.Where(arg => ids != arg.Id).ToList();
        //     var a = _context.Clothes.First(x => x.Id == ids);
        //     if (await js.InvokeAsync<bool>("confirm", $"Do you want to delete {a.Category}'s ({a.Id}) Record?"))
        //     {
        //         await client.DeleteAsync($"api/developer/{developerId}");
        //         await OnInitializedAsync();
        //     }
        // }
        // public async Task<Articles> Put(Articles article)
        // {
        //     _context.Entry(article).State = EntityState.Modified;
        //     await _context.SaveChangesAsync();
        //     return NoContent();
        // }
        public async Task UpdateArticle(Articles article)
        {
            _context.Clothes.Update(article);
            await _context.SaveChangesAsync();
        }
        public List<Articles> GetAllClothes()
            => this._context.Clothes.ToList();

        public async Task RemoveClothe(int id)
        {
            var dev = new Articles { Id = id };
            _context.Remove(dev);
            await _context.SaveChangesAsync();
        }
    }
}