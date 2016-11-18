using Nancy;
using System;
using System.Collections.Generic;

namespace Contacts.Objects
{
  public class Contact
  {
    private string _contactName;
    private string _address;
    private string _phoneNumber;
    private int _contactID;
    private static List<Contact> _allContacts = new List<Contact>{};

    public Contact (string ContactName, string Address, string PhoneNumber)
    {
      _contactName = ContactName;
      _address = Address;
      _phoneNumber = PhoneNumber;
      _contactID = _allContacts.Count;
      _allContacts.Add(this);
    }

    public string GetContactName()
    {
      return _contactName;
    }
    public void SetContactname(string NewName)
    {
      _contactName = NewName;
    }

    public string GetAddress()
    {
      return _address;
    }
    public void SetAddress(string NewAddress)
    {
      _address = NewAddress;
    }

    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }
    public void SetPhoneNumber(string NewNumber)
    {
      _phoneNumber = NewNumber;
    }

    public int GetID()
    {
      return _contactID;
    }
    public void SetID(int NewID)
    {
      _contactID = NewID;
    }

    public static List<Contact> GetContacts()
    {
      return _allContacts;
    }

    public static Contact FindContact(int contactId)
    {
      return _allContacts[contactId];
    }

    public int GetContactID()
    {
      return _contactID;
    }

    public static void ClearContacts()
    {
      _allContacts.Clear();
    }
  }
}
