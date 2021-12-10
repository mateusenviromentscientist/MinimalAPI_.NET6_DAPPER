namespace TodoApp
{
    public static class Api
    {
        public static void ConfigureApi(this WebApplication app)
        {
          
            app.MapGet("/User", GetUsers);
            app.MapGet("/Interfaces", GetTables);
            app.MapGet("/Users/{id}", GetUser);
            app.MapGet("/Company", GetCompanys);
            app.MapGet("/Companys/{id}", GetCompany);
            app.MapPost("/Users", InsertUser);
            app.MapPost("/Companys", InsertCompany);
            app.MapPut("/Users", UpdateUser);
            app.MapPut("/Companys", UpdateCompany);
            app.MapDelete("/Users", DeleteUser);
            app.MapDelete("Companys", DeleteCompany);
            
        }

        private static async Task<IResult> GetTables(ITableData data)
        {
            try
            {
                return Results.Ok(await data.GetTables());
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> GetUsers(IUserData data)
        {
            try
            {
                return Results.Ok(await data.GetUsers());
            }
            catch(Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> GetCompanys(ICompanyData data)
        {
            try
            {
                return Results.Ok(await data.GetCompanys());
            }
            catch(Exception ex)
            {
                return Results.Problem(ex.Message);            }
        }
  
        private static async Task<IResult>GetUser(int id, IUserData data)
        {
            try
            {
                var results = await data.GetUser(id);
                if (results == null) return Results.NotFound();
                return Results.Ok(results);
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task <IResult> GetCompany(int id, ICompanyData data)
        {
            try
            {
                var result = await data.GetCompany(id);
                if (result == null) return Results.NotFound();
                return Results.Ok(result);
            }
            catch(Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult>InsertUser(UserModel user, IUserData data)
        {
            try
            {
                await data.InsertUser(user);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult>InsertCompany(CompanyModel model, ICompanyData data)
        {
            try
            {
                await data.InsertCompany(model);
                return Results.Ok();
            }
            catch(Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> UpdateUser(UserModel user, IUserData data)
        {
            try
            {
                await data.UpdateUser(user);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

            
        private static async Task<IResult> UpdateCompany(CompanyModel model, ICompanyData data)
        {
            try
            {
                await data.UpdateCompany(model);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> DeleteUser(int id, IUserData data)
        {
            try
            {
                await data.DeleteUser(id);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> DeleteCompany(int id, ICompanyData data)
        {
            try
            {
                await data.DeleteCompany(id);
                return Results.Ok();
            }
            catch(Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
