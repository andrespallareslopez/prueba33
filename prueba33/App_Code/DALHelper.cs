using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace prueba33.App_Code
{

    //tomado esta libreria del ejemplo
    ///https://www.codeproject.com/Articles/898206/Generic-Data-Access-Helper-using-Entity-Framework


    public static class DALHelper
    {
        //Default
        public static bool GenericRetrieval<T>(Action<T> action) where T : DbContext, new()
        {
            using (var context=new T())
            {
                action(context);
                return true;
            }
        }
        //Forma de uso
        //----------------------------------------
        /*
        public List<Employee> GeAllEmployees()
        {
	        List<Employee> result= null;
	        bool success = DALHelper.GenericRetrival<NorthwindDBContext>((northwindContext) =>
	        {
		       result = (from e in northwindContext.Employees select e).ToList();
	        });
	        return result;
        }

        */
        //*******************************************************************************
        //Quering with a generic result
        public static TResult GenericResultRetrieval<T,TResult>(Func<T,TResult> func) where T: 
            DbContext,new() where TResult: new()
        {
            using(var context=new T())
            {
                TResult res = func(context);
                return res;
            }
        }
        //Forma de uso
        //--------------------------------------------------
        /*
            public List<Employee> GeAllEmployees()
            {
	           List<Employee> result = DALHelper.GenericResultRetrival<NorthwindDBContext,List<Employee>>((northwindContext) =>
	           {
		          return (from e in northwindContext.Employees select e).ToList();
	           });
	           return result;
            }
        */
        //*****************************************************************
        //quering asynchronously
        public static async Task<TResult> GenericRetrievalAsync<T,TResult>(Func<T,Task<TResult>> func)
            where T : DbContext,new()
            where TResult : new()
        {
            using (var context=new T())
            {
                return await func(context);
            }
        }
        //Forma de uso
        //---------------------------------------------------------
        /*
         public async Task<List<Employee>> GetAllEmployeesAsync()
         {
             return await DALHelper.GenericRetrivalAsync<NorthwindDBContext, List<Employee>>(async (northwindContext) =>
                   {
                        return await (from e in northwindContext.Employees select e).ToListAsync();
                   });
         }
         */
        //*********************************************************************
        //A long query with no locking tables asynchronously
        public static async Task<TResult> GenericResultNoLockLongRetrievalAsync<T,TResult>(Func<T,Task<TResult>> func)
            where T : DbContext, new() 
            where TResult : new()
        {
            using (var context=new T())
            {
                try
                {
                    ((IObjectContextAdapter)context).ObjectContext.CommandTimeout = 0;
                    using (var dbcontextTransaction = context.Database.BeginTransaction(IsolationLevel.ReadUncommitted))
                    {
                        return await func(context);
                    }
                }
                catch (Exception exception)
                {
                    return default(TResult);
                }
            }
        }
        //Querying from twice contexts asynchronously
        public static async Task<object>
    GenericTwiceContextsRetrivalAsync<T1, T2>(Func<T1, T2, Task<object>> func)
            where T1 : DbContext, new()
            where T2 : DbContext, new()
        {
            try
            {
                using (var context1 = new T1())
                {
                    using (
                        var dbContextTransaction1 = context1.Database.BeginTransaction(IsolationLevel.ReadUncommitted))
                    {
                        using (var context2 = new T2())
                        {
                            using (
                                var dbContextTransaction2 =
                                    context2.Database.BeginTransaction(IsolationLevel.ReadUncommitted)
                                )
                            {
                                return await func(context1, context2);
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                // Log Error

                return null;
            }
        }

       
        //Generic safe saving
        public static bool GenericSafeTransaction<T>(Action<T> action) where T : DbContext, new()
        {
            using (var context= new T())
            {
                using (var dbContextTransaction= context.Database.BeginTransaction())
                {
                    try
                    {
                        action(context);
                        dbContextTransaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        dbContextTransaction.Rollback();
                        return false;
                    }
                }
            }
        }
        //forma de uso
        //-------------------------------------------------------------
        //---------------------------------------------------------------------------
        /*
         public bool AddMultipleRecords(Employee newEmp, Supplier newSup)
         {
             return DALHelper.GenericSafeTransaction<NorthwindDBContextgt;(northwindContext =>
             {
                northwindContext.Employees.Add(newEmp);
                northwindContext.SaveChanges();
                northwindContext.Suppliers.Add(newSup);
                northwindContext.SaveChanges();
             });
         }
         */
        //Saving asynchronously
        public static async Task<int?> GenericSafeTransactionAsync<T>(Action<T> action)
            where T : DbContext, new()
        {
            using (var context = new T())
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        action(context);
                        int affectedRecords = await context.SaveChangesAsync();
                        dbContextTransaction.Commit();
                        return affectedRecords;
                    }
                    catch (Exception ex)
                    {
                        dbContextTransaction.Rollback();
                        // Log Error
                        return null;
                    }
                }
            }
        }
        //forma de uso
        //-------------------------------------------------------
        /*
            return await DALHelper.GenericSafeTransactionAsync<NorthwindDBContext>( async (northwindContext) =>
            {
	           northwindContext.Employees.Add(newEmp);
            })
        */
    }
}