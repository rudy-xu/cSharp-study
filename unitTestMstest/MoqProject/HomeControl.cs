using System;

namespace MoqProject
{
    public class HomeControl
    {
        private readonly IGetData _data;  
  
        public HomeControl(IGetData _data)  
        {  
            this._data = _data;  
        }    
        public string H_GetNameId(int id)  
        {  
            // for(int i=0; i<3;++i)
            // {
            //     Console.WriteLine("id: " + id);
            // }
            return _data.GetNameId(id);  
        }        
    }
}
