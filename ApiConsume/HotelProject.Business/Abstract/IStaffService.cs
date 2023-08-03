using HotelProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Business.Abstract;

public interface IStaffService
{
    void Insert(Staff staff);
    void Update(Staff staff);
    void Delete(Staff staff);
    List<Staff> GetAll();
    Staff GetById(int id);
}
