using ClickConnect.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClickConnect.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Mouse()
        {
            List<Mouse> ListaMouse = new List<Mouse>();

            Mouse mouse01 = new Mouse(1, "Grande", "Óptico", 29.99, 10, "Mouse Gamer", "Razer", "Preto");
            Mouse mouse02 = new Mouse(2, "Médio", "Laser", 19.99, 20, "Mouse de Escritório", "Logitech", "Branco");
            Mouse mouse03 = new Mouse(3, "Pequeno", "Óptico", 14.99, 15, "Mouse Sem Fio", "Microsoft", "Cinza");
            Mouse mouse04 = new Mouse(4, "Médio", "Laser", 24.99, 8, "Mouse Ergonômico", "Corsair", "Azul");
            Mouse mouse05 = new Mouse(5, "Grande", "Laser", 39.99, 5, "Mouse Vertical", "Delux", "Prata");

            ListaMouse.Add(mouse01); 
            ListaMouse.Add(mouse02);
            ListaMouse.Add(mouse03);
            ListaMouse.Add(mouse04);
            ListaMouse.Add(mouse05);

            return View(ListaMouse);

        }

        public IActionResult Teclado()
        {
            List<Teclado> ListaTeclado = new List<Teclado>();

            Teclado teclado01 = new Teclado(1, "Mecânico", 89.99, 10, "Teclado Gamer", "Razer", "Preto");
            Teclado teclado02 = new Teclado(2, "Membrana", 39.99, 15, "Teclado de Escritório", "Logitech", "Branco");
            Teclado teclado03 = new Teclado(3, "Mecânico", 119.99, 5, "Teclado Profissional", "Corsair", "Preto");
            Teclado teclado04 = new Teclado(4, "Mecânico", 149.99, 3, "Teclado RGB", "SteelSeries", "Preto");
            Teclado teclado05 = new Teclado(5, "Membrana", 29.99, 20, "Teclado Econômico", "Microsoft", "Cinza");

            ListaTeclado.Add(teclado01);
            ListaTeclado.Add(teclado02);
            ListaTeclado.Add(teclado03);
            ListaTeclado.Add(teclado04);
            ListaTeclado.Add(teclado05);

            return View(ListaTeclado);
        }

        public IActionResult Mousepad()
        {
            List<Mousepad> ListaMousepad = new List<Mousepad>();

            Mousepad mousepad01 = new Mousepad(1, "Grande", "Control", 19.99, 10, "Mousepad Gamer", "Razer", "Preto");
            Mousepad mousepad02 = new Mousepad(2, "Pequeno", "Speed", 9.99, 20, "Mousepad Compacto", "SteelSeries", "Vermelho");
            Mousepad mousepad03 = new Mousepad(3, "Médio", "Hybrid", 14.99, 15, "Mousepad Híbrido", "Corsair", "Azul");
            Mousepad mousepad04 = new Mousepad(4, "Grande", "Control", 24.99, 8, "Mousepad Profissional", "HyperX", "Preto");
            Mousepad mousepad05 = new Mousepad(5, "Médio", "Speed", 12.99, 5, "Mousepad Gamer", "Logitech", "Preto");

            ListaMousepad.Add(mousepad01);
            ListaMousepad.Add(mousepad02);
            ListaMousepad.Add(mousepad03);
            ListaMousepad.Add(mousepad04);
            ListaMousepad.Add(mousepad05);

            return View(ListaMousepad);
        }



        

    }
}
