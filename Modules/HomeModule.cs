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
      //Insert your GETs and POSTs here
    }
  }
}
