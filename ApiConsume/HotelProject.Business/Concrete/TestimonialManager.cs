using FluentValidation;
using HotelProject.Business.Abstract;
using HotelProject.Business.Rules.Validaiton;
using HotelProject.Core.Helpers.FileHelper;
using HotelProject.Core.Utilities.Constants;
using HotelProject.DataAccess.Abstract;
using HotelProject.DataAccess.EntityFramework;
using HotelProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Business.Concrete;

public class TestimonialManager : ITestimonialService
{
    private readonly ITestimonialDal testimonialDal;
    private readonly IFileHelper fileHelper;
    private readonly TestimonialValidator validator;

    public TestimonialManager(ITestimonialDal testimonialDal, IFileHelper fileHelper, TestimonialValidator validator)
    {
        this.testimonialDal = testimonialDal;
        this.fileHelper = fileHelper;
        this.validator = validator;
    }

    public void Delete(Testimonial testimonial)
    {
        fileHelper.DeleteFile(testimonial.Image);
        testimonialDal.Delete(testimonial);
    }

    public List<Testimonial> GetAll()
    {
        return testimonialDal.GetAll();
    }

    public Testimonial GetById(int id)
    {
       return testimonialDal.GetByID(id);
    }

    public void Insert(Testimonial testimonial)
    {

        var fileResult = fileHelper.AddFile(testimonial.ImageFile, Paths.Testimonial.Image);
     
        string imagePath = Path.Combine("images/testimonial/", fileResult);
      
        testimonial.Image = imagePath;

        testimonialDal.Insert(testimonial);
    }
    public void Update(Testimonial testimonial)
    {
        if(testimonial.ImageFile != null)
        {
            var fileResult = fileHelper.UpdateFile(testimonial.ImageFile, testimonial.Image, Paths.Testimonial.Image);

            string imagePath = Path.Combine("images/testimonial/", fileResult);
            testimonial.Image = imagePath;
        }
        else
        {
            testimonial.Image = testimonial.Image;
        }
        testimonialDal.Update(testimonial);
    }

}