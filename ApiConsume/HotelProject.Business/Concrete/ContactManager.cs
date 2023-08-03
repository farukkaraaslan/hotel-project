using HotelProject.Business.Abstract;
using HotelProject.DataAccess.Abstract;
using HotelProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Business.Concrete;
public class ContactManager : IContactService
{
    private readonly IContactDal contactDal;

    public ContactManager(IContactDal contactDal)
    {
        this.contactDal = contactDal;
    }

    public void Delete(Contact contact)
    {
        contactDal.Delete(contact);
    }

    public List<Contact> GetAll()
    {
       return contactDal.GetAll();
    }

    public Contact GetById(int id)
    {
       return contactDal.GetByID(id);
    }

    public void Insert(Contact contact)
    {
        contact.SendDate = DateTime.Now;
        contactDal.Insert(contact);
    }

    public void Update(Contact contact)
    {
        contactDal.Update(contact);
    }
}
