using CapaDatos.Contratos;
using CapaDatos.Entidades;
using CapaDatos.Repositorio;
using CapaNegocio.ValueObjects;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace CapaNegocio.Modelo
{
    public class ProductoModel
    {
        private int     _idProducto;
        private string  _nombre;
        private string  _categoria;
        private string  _marca;
        private int     _cantidadStock;
        private decimal _precio;

        // Propiedades
        public int      IdProducto      { get => _idProducto;       set => _idProducto      = value; }
        public string   Nombre          { get => _nombre;           set => _nombre          = value; }
        public string   Categoria       { get => _categoria;        set => _categoria       = value; }
        public string   Marca           { get => _marca;            set => _marca           = value; }
        public int      CantidadStock   { get => _cantidadStock;    set => _cantidadStock   = value; }
        public decimal  Precio          { get => _precio;           set => _precio          = value; }

        private IGenericRepository<Producto> _productoRepository;
        public EntityState State { private get; set; }


        public ProductoModel()
        {
            _productoRepository = new Productorepository();
        }

        //Metodo que usa entityState para guardar los cambios dependiendo del estado
        public string SaveChanges()
        {
            string message = "";
            try
            {
                var producto = new Producto
                {
                    idProducto = IdProducto,
                    nombre = Nombre,
                    categoria = Categoria,
                    marca = Marca,
                    cantidadStock = CantidadStock,
                    precio = Precio
                };

                switch (State)
                {
                    case EntityState.Added:
                        _productoRepository.añadir(producto);
                        message = "Se registró correctamente.";
                        break;
                    case EntityState.Modified:
                        _productoRepository.editar(producto);
                        message = "Se editó correctamente.";
                        break;
                    case EntityState.Deleted:
                        _productoRepository.eliminar(IdProducto);
                        message = "Se eliminó correctamente.";
                        break;
                }
            }
            catch (SqlException ex)
            {
                //Excepcion para controlar que se borren primero los productos asignados a una venta
                if (ex.Number == 547)
                {
                    message = "Primero deben borrarse las ventas asignadas a este producto.";
                }
                else
                {
                    message = "Ocurrió un error al eliminar el cliente: " + ex.Message;
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            return message;
        }

        //Metodo para obtener los datos de la tabla y devovlerlos como lsita
        public List<ProductoModel> obtener()
        {
            var tablaProductos = _productoRepository.obtener();
            var listProductos = new List<ProductoModel>();

            foreach (var item in tablaProductos)
            {
                listProductos.Add(new ProductoModel
                {
                    IdProducto = item.idProducto,
                    Nombre = item.nombre,
                    Categoria = item.categoria,
                    Marca = item.marca,
                    CantidadStock = item.cantidadStock,
                    Precio = item.precio
                });
            }
            return listProductos;
        }
    }
}
