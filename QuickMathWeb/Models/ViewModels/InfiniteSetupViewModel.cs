using Microsoft.AspNetCore.Mvc.Rendering;

namespace QuickMathWeb.Models.ViewModels
{
    public class InfiniteSetupViewModel
    {
        public string SelectedMap { get; set; }

        //Display Property
        public List<string> MapSelectList { get; set; }
        public InfiniteSetupViewModel() 
        { 
            MapSelectList = new List<string> 
            { 
                
            
            
            };
        
        
        
        
        
        }
    }
}
