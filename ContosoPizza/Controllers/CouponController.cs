using ContosoPizza.Data;
using ContosoPizza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class CouponController : ControllerBase
{
    PromotionsContext _context;

    public CouponController(PromotionsContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IEnumerable<Coupon> Get()
    {
        return _context.Coupons
            .AsNoTracking()
            .ToList();
    }

    [HttpGet("{id}")]
    public ActionResult<Coupon> GetById(int id) {
        var coupon =  _context.Coupons
            .AsNoTracking()
            .SingleOrDefault(x => x.Id == id);

        if (coupon is not null ) {
            return coupon;
        }
        return NotFound();
    }
}