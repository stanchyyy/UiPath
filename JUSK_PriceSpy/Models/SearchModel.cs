using System.Collections.Generic;


namespace JUSK_PriceSpy.Models
{
    public class SearchModel
    {
        public string ItemName {get;set;}
        
        public SearchModel (string itemName)
        {
            ItemName = itemName;
        }
    }
    

    
}