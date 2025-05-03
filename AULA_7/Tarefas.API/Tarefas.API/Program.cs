using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Tarefas.API.Context;
using Tarefas.API.Models;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new OpenApiInfo {
        Title = "API de Tarefas",
        Version = "v1",
        Description = "Uma API simples para gerenciar tarefas!"
    });
});

var connectionString = "Data Source=tarefas.db";
builder.Services.AddSqlite<TarefasDBContext>(connectionString);

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI(c => {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API de Tarefas V1");
        //c.RoutePrefix = string.Empty;
    });
}

// 
app.UseHttpsRedirection();

app.MapGet("/Categorias", async(TarefasDBContext db) => await db.Categorias.ToListAsync());

app.MapGet("/Categorias/{id}", async (TarefasDBContext db, int id) => {
    var categoria = await db.Categorias.FindAsync(id);
    if (categoria == null) {
        return Results.NotFound();
    }
    return Results.Ok(categoria);
});

app.MapPost("/Categorias", async (TarefasDBContext db, Categoria categoria) => {
    if (categoria == null) {
        return Results.BadRequest("Requisição Inválida!");
    }

    db.Categorias.Add(categoria);
    await db.SaveChangesAsync();
    return Results.Created($"/Categorias/{categoria.CategoriaId}", categoria);
});

app.MapPut("/Categorias/{id}", async (TarefasDBContext db, int id, Categoria categoriaAtualizada) => {
    var categoriaExistente = await db.Categorias.FindAsync(id);

    if (categoriaExistente == null) {
        return Results.NotFound();
    }

    categoriaExistente.Nome = categoriaAtualizada.Nome;
    await db.SaveChangesAsync();
    return Results.Ok("Categoria atualizada com sucesso!");
});

app.MapDelete("/Categorias/{id}", async (TarefasDBContext db, int id) => {
    var categoria = await db.Categorias.FindAsync(id);

    if (categoria == null) {
        return Results.NotFound();
    }

    db.Categorias.Remove(categoria);
    await db.SaveChangesAsync();
    return Results.Ok("Categoria removida com sucesso!");
});

app.Run();
