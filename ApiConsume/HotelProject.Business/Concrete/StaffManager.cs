using HotelProject.Business.Abstract;
using HotelProject.Core.Helpers.FileHelper;
using HotelProject.Core.Utilities.Constants;
using HotelProject.DataAccess.Abstract;
using HotelProject.DataAccess.EntityFramework;
using HotelProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Business.Concrete;

public class StaffManager : IStaffService
{
    private readonly IStaffDal stafDal;
    private readonly IFileHelper fileHelper;

    public StaffManager(IStaffDal stafDal, IFileHelper fileHelper)
    {
        this.stafDal = stafDal;
        this.fileHelper = fileHelper;
    }

    public void Delete(Staff staff)
    {
        fileHelper.DeleteFile(staff.Image);
        stafDal.Delete(staff);
    }

    public List<Staff> GetAll()
    {
        return stafDal.GetAll();
    }

    public Staff GetById(int id)
    {
        return stafDal.GetByID(id);
    }

    public void Insert(Staff staff)
    {

        var fileResult = fileHelper.AddFile(staff.ImageFile, Paths.Staff.Image);

        string imagePath = Path.Combine("images/staff/", fileResult);

        staff.Image = imagePath;

        stafDal.Insert(staff);
    }
    public void Update(Staff staff)
    {
        if(staff.ImageFile != null)
        {
            var fileResult = fileHelper.UpdateFile(staff.ImageFile, staff.Image, Paths.Staff.Image);

            string imagePath = Path.Combine("images/staff/", fileResult);
            staff.Image = imagePath;
        }
        else
        {
            staff.Image=staff.Image;
        }
        

        stafDal.Update(staff);
    }
}