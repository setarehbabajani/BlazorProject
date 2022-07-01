using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BuyStarOn.Server.DB;
using BuyStarOn.Shared;



namespace BuyStarOn.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // api/Clothe
    public class ClotheController : Controller
    {
        // [HttpGet("getAllClothes")] // api/Clothe/getAllClothes
        // [HttpGet]
        [Route("getAllClothes")] // api/Clothe/getAllClothes
        public List<Articles> getAllClothes() => this._provider.GetAllClothes();

        // [HttpGet("{id}")]
        // [Route("getClotheById")]
        // [HttpGet("getClotheById/{id}")]
        // public Articles getClotheById(int id) => ClotheController.Clothes.Where(clothe => clothe.Id == id).FirstOrDefault();//-->agar vojod nadasht null mideh.
        // System.Linq.Enumerable.Where(ClotheController.Clothes,Clothe => Clothe.ID == id).FirstOrDefault();
        //getAllClothes().Where(clothe => clothe.ID == id).FirstOrDefault();


        // [HttpDelete]
        // [Route("RemoveClothes")]//-->[]
        // public List<Articles> RemoveClothes(int[] ids)
        // {
        //     Clothes = Clothes.Where(arg => ids.Contains(arg.Id)).ToList();//اونایی که ای دی مورد نظر داشتن میمونن
        //     return Clothes;
        // }

        // [HttpPut]
        // [Route("UpdateClotheName")]//-->Params
        // // [HttpPut("UpdateClotheName/{id}/{name}")]
        // public Articles UpdateClotheName(int id,string newname)
        // {
        //     var clothe = Clothes.Where(arg => arg.Id == id).FirstOrDefault();//یکی از ای دی هارو ای دی مورد نظر میذاره
        //     clothe.Name = newname;
        //     return clothe;
        // }

        // [HttpPut]
        // [Route("UpdateClothe")]
        // public Articles UpdateClothe(Articles newClothe)
        // {
        //     var idx = Clothes.IndexOf(newClothe) + 1;
        //     Clothes[idx] = newClothe;
        //     return Clothes[idx];
        // }

        private readonly ClotheProvider _provider;
        public ClotheController(ClotheProvider provider)
        {
            this._provider = provider;
        }
        
        [HttpPost]
        [Route("AddNewClotheToDB")]
        public  async Task<Articles> AddNewClotheToDB(Articles newClothe)
        {
            await this._provider.AddClothe(newClothe);
            return newClothe;
        }

        // [HttpDelete]
        // [Route("RemoveClothe/{id}")]
        [HttpDelete("{id}")]
        public  async Task<ClotheProvider> Delete(int id)
        {
            await this._provider.RemoveClothe(id);
            return _provider;
        }

        [HttpPut]
        [Route("UpdateArticle")]
        public async Task<Articles> UpdateArticle(Articles article)
        {
            await this._provider.UpdateArticle(article);
            return article;
        }
    }
}

