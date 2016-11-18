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
      Post["/submitContact"] = _ => {
        Contact newContact = new Contact(Request.Form["contact-name"], Request.Form["contact-address"], Request.Form["contact-number"]);
        var ContactList = Contact.GetContacts();
        return View["index.cshtml", ContactList];
      };
      Get["/contacts/{id}"] = parameters => {
        Contact contact = Contact.FindContact(parameters.id);
        return View["display_contact.cshtml", contact];
      };
      Post["/deleteAll"] = _ => {
        Contact.ClearContacts();
        return View["confirmation.cshtml"];
      };
    }
  }
}
