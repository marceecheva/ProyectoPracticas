﻿using CapaDatos;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaLogica
{
    public class CL_Metodos
    {
        CD_Metodos metodos = new CD_Metodos();

        #region METODOS
        //public Usuarioactual DatosIngreso(string Usuario)
        //{
        //    return metodos.DatosIngreso(Usuario);
        //}
        public DataTable ProductosStockMin()
        {
            return metodos.ProductosStockMin();
        }
        public DataTable DetallePR(int idpr)
        { 
            return metodos.DetallePR(idpr);
        }
        public DataTable PRpedidos()
        { 
            return metodos.PRpedidos();
        }
        public int BorrardetallePR(int iddetallepr)
        {
            return metodos.BorrardetallePR(iddetallepr);
        }
        public int ActualizarDetallPR(int iddetallepr, int IdPR, int CantidadNueva, int Usuariomodificacion, DateTime Fechamodificacion)
        {
            return metodos.ActualizarDetallPR(iddetallepr, IdPR, CantidadNueva, Usuariomodificacion, Fechamodificacion);
        }
        public int ActualizarUsuario(string usuario, string nombre, string apellido, string dni, int rol, int bloqueado)
        {
            return metodos.ActualizarUsuario(usuario, nombre, apellido, dni, rol, bloqueado);
        }
        public int Bitacora(string descripcion, DateTime fecha)
        { 
            return metodos.Bitacora(descripcion, fecha);
        }
        public string InsertarCate(string nombre)
        {
            return metodos.InsertarCate(nombre);
        }
        public string ActualizarCate(int id,string nombre)
        {
            return metodos.ActualizarCate(id,nombre);
        }
        public DataTable Categorias()
        {
            return metodos.Categorias();
        }
        public string InsertarProducto(string codigo, string descripcion, string cate, int stockmin, int stockmax, string unidadcarga, int cantunicarga, int cantporunicarga, int vendeporunidades, int vendeporkilo, int vendeporpack, decimal precioporunidad, decimal precioporkilo, decimal precioporpack, int usuarioalta, string usuarioreferencia, List<(int cantidadMinima, int porcentaje)> descuentos)
        {
            return metodos.InsertarProducto(codigo, descripcion,cate, stockmin, stockmax, unidadcarga, cantunicarga, cantporunicarga, vendeporunidades, vendeporkilo, vendeporpack, precioporunidad, precioporkilo, precioporpack, usuarioalta,usuarioreferencia,descuentos);
        }

        public DataTable MostrarTodo(string Tabla)
        {
            return metodos.MostrarTodo(Tabla);
        }
        public string Registro(string usuario, string clave, string nombre, string apellido)
        {
            return metodos.Registro(usuario,clave,nombre, apellido);
        }

        public int StatusBloq(string Usuario)
        { 
            return metodos.StatusBloq(Usuario);
        }
        public int InsertarVentas(decimal total)
        {
            return metodos.InsertarVentas(total);
        }
        public int BorrarUsuario(string usuario)
        {
            return metodos.BorrarUsuario(usuario);
        }
        public string InsertarPR(int idusuario, DataTable detallepr)
        {
            return metodos.InsertarPR(idusuario,detallepr);
        }
        #endregion
    }
}
