// See https://aka.ms/new-console-template for more information
using System;

using System.Data.SqlClient;
using System.Data.SqlTypes;

internal class Program
{ 
    private static void Main(string[] args)
    {
        string cs = "data source= DESKTOP-D8P2U76; database =shpes ; integrated Security = true";
        SqlConnection con = new SqlConnection(cs);
        //insert data to data base
        string insertt = string.Format("INSERT INTO dbo.shapefamily(shape,id,valuee,noAngle,Parent,colour)\r\nvalues('new',1,20,1,'shape','gray');");
        //SqlCommand cmd = new SqlCommand(insert,con);
        //con.open
        //cmd.ExecuteNonQuery();

        //get data from data base
        string qu =" SELECT * FROM dbo.shapefamily" ;
        SqlCommand cmd = new SqlCommand(qu,con);

        con.Open();
        SqlDataReader rdr = cmd.ExecuteReader();
        Console.WriteLine("Shape type     id  value   noAng  Parent Class     colour");
        if(rdr.HasRows)
        {
            while(rdr.Read())
            {
                Console.WriteLine("{0}      {1}     {2}     {3}     {4}     {5}", rdr["shape"], rdr["id"], rdr["valuee"], rdr["noAngle"], rdr["Parent"],rdr["colour"]);
            }

        }
    

    }
}