namespace MoqProject
{
    public class Employee : IGetData
    {
        public string GetNameId(int id)  
        {  
            string name;  
            if (id == 1)  
            {  
                name = "Jack";  
            }  
            else if (id == 2)  
            {  
                name = "Tom";  
            }  
            else  
            {  
                name = "Not Found";  
            }  
            return name;  
        } 
    }
}