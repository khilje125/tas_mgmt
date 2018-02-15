﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TAS_Stock
{
    class Categorie
    {
        public DataTable getCategories()
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            tab = db.getData("spr_get_Categories", null);
            db.closeConnection();
            return tab;
        }

        public void insertCategory(string name)
        {

            DB db = new DB();
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@cat_name", SqlDbType.VarChar);
            parameters[0].Value = name;

            db.setData("spr_insert_category", parameters);
            db.closeConnection();

        }

        public void insertclass(string name)
        {

            DB db = new DB();
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@ClassName", SqlDbType.VarChar);
            parameters[0].Value = name;

            db.setData("spr_insert_class", parameters);
            db.closeConnection();

        }
        public DataTable getClass()
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            tab = db.getData("[spr_get_Class]", null);
            db.closeConnection();
            return tab;
        }
        public void updateClass(string name,string oldval)
        {

            DB db = new DB();
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@c_name_new", SqlDbType.VarChar);
            parameters[0].Value = name;
            parameters[1] = new SqlParameter("@c_name_old", SqlDbType.VarChar);
            parameters[1].Value = oldval;

            db.setData("[spr_update_class]", parameters);
            db.closeConnection();

        }
        public DataTable searchProducts(string valueToSearch)
        {

            DB db = new DB();
            DataTable table = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@val", SqlDbType.VarChar, 100);
            parameters[0].Value = valueToSearch;
            table = db.getData("spr_search_Products", parameters);
            db.closeConnection();
            return table;
        }

        public void deleteCategory(int product_id)
        {

            DB db = new DB();
            DataTable table = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@cid", SqlDbType.Int);
            parameters[0].Value = product_id;

            db.openConnection();
            db.setData("spr_delete_category", parameters);
            db.closeConnection();

        }

        public void updateCategory(int cid, string name)
        {

            DB db = new DB();
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[2];

            parameters[0] = new SqlParameter("@c_id", SqlDbType.Int);
            parameters[0].Value = cid;

            parameters[1] = new SqlParameter("@c_name", SqlDbType.VarChar);
            parameters[1].Value = name;

            db.setData("spr_update_category", parameters);
            db.closeConnection();

        }
    }
}
