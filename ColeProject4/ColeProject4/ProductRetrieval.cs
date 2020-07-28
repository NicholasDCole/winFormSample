using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeProject4
{
    public class ProductRetrieval
    {
        public DataTable dt;
        public ProductRetrieval()
        {

        }

        public ProductRetrieval(string categoryNumber)
        {
            dt = new DataTable();
            EstablishDataBaseConnection(categoryNumber);
        }
        
        private void EstablishDataBaseConnection(string categoryNumber)
        {
            try
            {
                SqlConnection conn = new SqlConnection("ENTER CONNECTION STRING HERE");
                conn.Open();
                SqlCommand command= new SqlCommand("SELECT p.Name, ThumbNailPhoto, ListPrice, Description FROM Production.Product p INNER JOIN " +
"Production.ProductSubcategory ps ON p.ProductSubcategoryID = ps.ProductSubcategoryID INNER JOIN Production.ProductCategory pc ON ps.ProductCategoryID = pc.ProductCategoryID INNER JOIN " +
"Production.ProductModelProductDescriptionCulture pmpdc ON p.ProductModelID = pmpdc.ProductModelID INNER JOIN Production.ProductDescription pd ON pmpdc.ProductDescriptionID = pd.ProductDescriptionID " +
"INNER JOIN Production.ProductProductPhoto ppp ON p.ProductID = ppp.ProductID INNER JOIN Production.ProductPhoto pp ON ppp.ProductPhotoID = pp.ProductPhotoID " +
"LEFT JOIN(SELECT ProductID, MAX(StartDate) as StartDate FROM Production.ProductCostHistory GROUP BY ProductID) pch ON p.ProductID = pch.ProductID " +
"WHERE CultureID = 'en' AND Ps.ProductCategoryID = " + categoryNumber + " ORDER BY p.Name ASC", conn);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    dt.Load(dr);
                }
            } catch(Exception e)
            {

            }           
        }
    }
}
