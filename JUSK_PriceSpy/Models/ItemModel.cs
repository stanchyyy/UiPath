using JUSK_PriceSpy.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Data;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace JUSK_PriceSpy.Models
{
    public class ItemModel
    {
        public string Name {get;set;}
        public string ShortDescription {get;set;}
        public string Price {get;set;}
        public string URL {get;set;}
        
        public ItemModel(string name,string url, string shortDescription, string price)
        {
            Name = name;
            ShortDescription = shortDescription;
            Price = price;
            URL = url;
        }
        
        public override string ToString()
        {
            return (@$"Product {Name}.<br>
                Description {ShortDescription}.<br>
                Sells for {Price}.<br>
                The product URL is : {URL}.<br>");
        }
    }
    
}