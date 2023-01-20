using Data_Access_Layer.Data_Access_Layer;
using Domain_Layer;
using Fiery.Restaurant.DTO;
using Fiery.Restaurant.Service.FieryService.Implementation;
using Fiery.Restaurant.Service.FieryService.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fiery_Restaurant_Hackthon.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class SupplierController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get() 
        {
            return Ok("Done");
        }
        //private ISupplierService service = new SupplierService();
        //public SupplierDBContext supplierDB = new SupplierDBContext();
        //public SupplierController(ISupplierService service, Supplie
        //    rDBContext supplierDB)
        //{
        //    //this.service = service;
        //    //this.supplierDB = supplierDB;
        //}



        //[HttpPost]
        //[Route("add")]
        //public IActionResult AddNewSupplier(Supplier supplier)
        //{

        //    try
        //    {
        //       supplierDB.Suppliers.Add(supplier);
        //        supplierDB.SaveChanges();
        //        return Ok("Not Found");
        //    }
        //    catch(Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
            
        //}
        //[HttpGet]
        //[Route("id")]
        //[ActionName("GetSupplier")]
        //public ActionResult<List<Supplier>> GetSupplier(int supplierId)
        //{
        //    try
        //    {
        //        SupplierDTO suppliers = service.GetSupplier(supplierId);
        //        if (suppliers != null)
        //        {
        //            return Ok(suppliers);
        //        }
        //        return NotFound("Supplier not found");
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}


        //[HttpGet]

        //public ActionResult<SupplierDTO> GetSuppliers()
        //{
        //    try
        //    {
        //        List<SupplierDTO> supplierDto = service.GetSuppliers();
        //        if (supplierDto != null)
        //        {
        //            return Ok(supplierDto);
        //        }
        //        return NotFound("Suppliers Not Found");
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

    }
}
