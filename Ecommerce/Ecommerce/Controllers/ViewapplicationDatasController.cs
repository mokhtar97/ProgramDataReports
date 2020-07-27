using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Models;
using Ecommerce.Models.Repositories;

using PagedList;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViewapplicationDatasController : ControllerBase
    {
        
        private readonly IStore<ViewapplicationData> viewdata;

        public ViewapplicationDatasController(ApplicationDbcontext context,IStore<ViewapplicationData> viewdata)
        {
          
            this.viewdata = viewdata;
        }

        // GET: api/ViewapplicationDatas
        [HttpGet]
        public  PagedList.IPagedList<ViewapplicationData> GetViewapplicationData(int? pageNumber)
        {
        
           
            return viewdata.List().ToPagedList(pageNumber ?? 1, 5); 
       
        }

       

        // PUT: api/ViewapplicationDatas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        

        // POST: api/ViewapplicationDatas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
       
        // DELETE: api/ViewapplicationDatas/5
        
        
    }
}
