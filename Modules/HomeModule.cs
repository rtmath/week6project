using Nancy;
using System;
using System.Collections.Generic;
using Contacts.Objects;

namespace Contacts
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        var ContactList = Contact.GetContacts();
        return View["index.cshtml", ContactList];
      };
      Get["/create"] = _ => {
        return View["create_new.cshtml"];
      };
      Post["/test"] = _ => {
        Contact newContact = new Contact("Sample Name", "Sample Address", 1234567890);
        var ContactList = Contact.GetContacts();
        ContactList.Add(newContact);
        return View["index.cshtml", ContactList];
      };
      Post["/submitContact"] = _ => {
        string formName = Request.Form["contact-name"];
        string formAddress = Request.Form["contact-address"];
        int formNumber = Request.Form["contact-number"];
        Contact newContact = new Contact(formName, formAddress, formNumber);
        var ContactList = Contact.GetContacts();
        ContactList.Add(newContact);
        return View["index.cshtml", ContactList];
      };
      //Insert your GETs and POSTs here
    }
  }
}
