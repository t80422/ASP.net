using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    //繼承Controller就是走MVC架構
    public class HelloController : Controller
    {
        //打招呼的Action回應一個簡單文字到前端
        //回應值 代表每一種View 可以多種類型 使用介面多型化設計
        public IActionResult HelloWorld()
        {
            string msg = "<font size='12' color='red'>小咪喵喵叫</font>";
            return Content(msg,"text/html;charset=UTF-8");
        }

        //調用頁面 經由Razor引擎調用頁面.cshtml
        public IActionResult showHelloPage()
        {
            //調頁面 若沒有指定View Name 預設會使用同方法名稱的頁面(showHelloPage)
            return View();
        }
    }
}
