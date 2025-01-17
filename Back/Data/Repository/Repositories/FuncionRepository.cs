﻿using Back.Data.Models;
using Back.Data.Repository.Interfaces;
using Back.Data.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Back.Data.Repository.Repositories
{
    public class FuncionRepository : IFuncionRepository
    {
        private readonly CineDBContext _context;

        public FuncionRepository(CineDBContext context)
        {
            _context = context;
        }


        public async Task<bool> Delete(int id)
        {
            var funcion = await GetById(id);
            if (funcion != null && funcion.Estado == true)
            {
                funcion.Estado = false;
                return await _context.SaveChangesAsync() != 0;
            }
            else if (funcion != null && funcion.Estado == false)
            {
                funcion.Estado = true;
                return await _context.SaveChangesAsync() != 0;
            }
            else
            {
                return false;
            }
        }
        public async Task<List<Funcione>> GetAll()
        {
            return await _context.Funciones.ToListAsync();
        }

        public async Task<List<Funcione>>? GetByDay(int day)
        {
            return await _context.Funciones.Where(d => d.Dia == day).ToListAsync();
        }

        public async Task<Funcione>? GetById(int id)
        {
            var funcion = await _context.Funciones.FirstOrDefaultAsync(f => f.CodFuncion == id);
            if (funcion != null)
            {
                return funcion;
            }
            return null;
        }

        public async Task<bool> Save(Funcione funcione)
        {
            if (funcione.CodFuncion == 0)
            {
                _context.Funciones.Add(funcione);
            }
            else
            {
                _context.Funciones.Update(funcione);
            }
            return await _context.SaveChangesAsync() != 0;
        }
    }
}
