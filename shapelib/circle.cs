namespace shapelib
{
    public class circle:ishape
    {
            public int radius { get; set; }
            
            public string draw()
            {
            return $"{this.radius} this is draw";
            }
            public string getdetails()
            {
                
                int r = this.radius;
                int d= this.radius;
                d = r + r;
                float area = (float)(Math.PI * r * r);
                float circum = (float)( 2* Math.PI * r );
                return $"{d} is the diameter of circle \n{area}  is the area of circle \n{circum}  is the circumference of circle \n{this.radius} is the radius of circle";


        }
        

        void ishape.draw()
        {
            throw new NotImplementedException();
        }

        void ishape.getdetails()
        {
            throw new NotImplementedException();
        }
    }
        
    
       
   
}