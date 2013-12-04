using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DALChange
/// </summary>
public class DALChange
{

    public GymCheckinDataContext dc = new GymCheckinDataContext();






    // UPDATE FIRSTNAME


    public void newFirst(tbl_user p_First)
    {
        // find row to update
        var query =
            from f in dc.tbl_users
            where f.user_tiwtter == p_First.user_tiwtter
            where f.user_password == p_First.user_password
            select f;


        List<tbl_user> x = query.ToList();

        //update

        foreach (tbl_user person in query)
        { 
            person.user_firstname = p_First.user_firstname;
        }

        try
        {
            dc.SubmitChanges();
        }

        catch (Exception e)
        {
            Console.WriteLine(e);
            // Provide for exceptions.
        }


    }








    // UPDATE LASTNAME




    public void newLast(tbl_user p_Last)
    {
        // find row to update
        var query =
            from f in dc.tbl_users
            where f.user_tiwtter == p_Last.user_tiwtter
            where f.user_password == p_Last.user_password
            select f;


        List<tbl_user> x = query.ToList();

        //update

        foreach (tbl_user person in query)
        {
            person.user_lastname = p_Last.user_lastname;
        }

        try
        {
            dc.SubmitChanges();
        }

        catch (Exception e)
        {
            Console.WriteLine(e);
            // Provide for exceptions.
        }


    }









    // UPDATE PASSWORD



    public void newPass(tbl_user p_pass)
    {
        // find row to update
        var query =
            from f in dc.tbl_users
            where f.user_tiwtter == p_pass.user_tiwtter
            select f;


        List<tbl_user> x = query.ToList();

        //update

        foreach (tbl_user person in query)
        {
            person.user_password = p_pass.user_password;
        }

        try
        {
            dc.SubmitChanges();
        }

        catch (Exception e)
        {
            Console.WriteLine(e);
            // Provide for exceptions.
        }


    }







}

