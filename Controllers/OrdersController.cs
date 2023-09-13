using Microsoft.AspNetCore.Mvc;

namespace OrderAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        [HttpGet]
        public async Task GetOrders()
        {
            HttpContext.Response.StatusCode = 200;
            HttpContext.Response.ContentType = "application/json";

            var json = "{\r\n    \"@odata.context\": \"https://services.odata.org/V4/Northwind/Northwind.svc/$metadata#Orders(OrderID,CustomerID,OrderDate,ShippedDate,ShipName,ShipAddress,ShipCountry)\",\r\n    \"value\": [\r\n        {\r\n            \"OrderID\": 10248,\r\n            \"CustomerID\": \"VINET\",\r\n            \"OrderDate\": \"1996-07-04T00:00:00Z\",\r\n            \"ShippedDate\": \"1996-07-16T00:00:00Z\",\r\n            \"ShipName\": \"Vins et alcools Chevalier\",\r\n            \"ShipAddress\": \"59 rue de l'Abbaye\",\r\n            \"ShipCountry\": \"France\"\r\n        },\r\n        {\r\n            \"OrderID\": 10249,\r\n            \"CustomerID\": \"TOMSP\",\r\n            \"OrderDate\": \"1996-07-05T00:00:00Z\",\r\n            \"ShippedDate\": \"1996-07-10T00:00:00Z\",\r\n            \"ShipName\": \"Toms Spezialit�ten\",\r\n            \"ShipAddress\": \"Luisenstr. 48\",\r\n            \"ShipCountry\": \"Germany\"\r\n        },\r\n        {\r\n            \"OrderID\": 10250,\r\n            \"CustomerID\": \"HANAR\",\r\n            \"OrderDate\": \"1996-07-08T00:00:00Z\",\r\n            \"ShippedDate\": \"1996-07-12T00:00:00Z\",\r\n            \"ShipName\": \"Hanari Carnes\",\r\n            \"ShipAddress\": \"Rua do Pa�o, 67\",\r\n            \"ShipCountry\": \"Brazil\"\r\n        },\r\n        {\r\n            \"OrderID\": 10251,\r\n            \"CustomerID\": \"VICTE\",\r\n            \"OrderDate\": \"1996-07-08T00:00:00Z\",\r\n            \"ShippedDate\": \"1996-07-15T00:00:00Z\",\r\n            \"ShipName\": \"Victuailles en stock\",\r\n            \"ShipAddress\": \"2, rue du Commerce\",\r\n            \"ShipCountry\": \"France\"\r\n        },\r\n        {\r\n            \"OrderID\": 10252,\r\n            \"CustomerID\": \"SUPRD\",\r\n            \"OrderDate\": \"1996-07-09T00:00:00Z\",\r\n            \"ShippedDate\": \"1996-07-11T00:00:00Z\",\r\n            \"ShipName\": \"Supr�mes d�lices\",\r\n            \"ShipAddress\": \"Boulevard Tirou, 255\",\r\n            \"ShipCountry\": \"Belgium\"\r\n        },\r\n        {\r\n            \"OrderID\": 10253,\r\n            \"CustomerID\": \"HANAR\",\r\n            \"OrderDate\": \"1996-07-10T00:00:00Z\",\r\n            \"ShippedDate\": \"1996-07-16T00:00:00Z\",\r\n            \"ShipName\": \"Hanari Carnes\",\r\n            \"ShipAddress\": \"Rua do Pa�o, 67\",\r\n            \"ShipCountry\": \"Brazil\"\r\n        },\r\n        {\r\n            \"OrderID\": 10254,\r\n            \"CustomerID\": \"CHOPS\",\r\n            \"OrderDate\": \"1996-07-11T00:00:00Z\",\r\n            \"ShippedDate\": \"1996-07-23T00:00:00Z\",\r\n            \"ShipName\": \"Chop-suey Chinese\",\r\n            \"ShipAddress\": \"Hauptstr. 31\",\r\n            \"ShipCountry\": \"Switzerland\"\r\n        },\r\n        {\r\n            \"OrderID\": 10255,\r\n            \"CustomerID\": \"RICSU\",\r\n            \"OrderDate\": \"1996-07-12T00:00:00Z\",\r\n            \"ShippedDate\": \"1996-07-15T00:00:00Z\",\r\n            \"ShipName\": \"Richter Supermarkt\",\r\n            \"ShipAddress\": \"Starenweg 5\",\r\n            \"ShipCountry\": \"Switzerland\"\r\n        },\r\n        {\r\n            \"OrderID\": 10256,\r\n            \"CustomerID\": \"WELLI\",\r\n            \"OrderDate\": \"1996-07-15T00:00:00Z\",\r\n            \"ShippedDate\": \"1996-07-17T00:00:00Z\",\r\n            \"ShipName\": \"Wellington Importadora\",\r\n            \"ShipAddress\": \"Rua do Mercado, 12\",\r\n            \"ShipCountry\": \"Brazil\"\r\n        },\r\n        {\r\n            \"OrderID\": 10257,\r\n            \"CustomerID\": \"HILAA\",\r\n            \"OrderDate\": \"1996-07-16T00:00:00Z\",\r\n            \"ShippedDate\": \"1996-07-22T00:00:00Z\",\r\n            \"ShipName\": \"HILARION-Abastos\",\r\n            \"ShipAddress\": \"Carrera 22 con Ave. Carlos Soublette #8-35\",\r\n            \"ShipCountry\": \"Venezuela\"\r\n        },\r\n        {\r\n            \"OrderID\": 10258,\r\n            \"CustomerID\": \"ERNSH\",\r\n            \"OrderDate\": \"1996-07-17T00:00:00Z\",\r\n            \"ShippedDate\": \"1996-07-23T00:00:00Z\",\r\n            \"ShipName\": \"Ernst Handel\",\r\n            \"ShipAddress\": \"Kirchgasse 6\",\r\n            \"ShipCountry\": \"Austria\"\r\n        },\r\n        {\r\n            \"OrderID\": 10259,\r\n            \"CustomerID\": \"CENTC\",\r\n            \"OrderDate\": \"1996-07-18T00:00:00Z\",\r\n            \"ShippedDate\": \"1996-07-25T00:00:00Z\",\r\n            \"ShipName\": \"Centro comercial Moctezuma\",\r\n            \"ShipAddress\": \"Sierras de Granada 9993\",\r\n            \"ShipCountry\": \"Mexico\"\r\n        },\r\n        {\r\n            \"OrderID\": 10260,\r\n            \"CustomerID\": \"OTTIK\",\r\n            \"OrderDate\": \"1996-07-19T00:00:00Z\",\r\n            \"ShippedDate\": \"1996-07-29T00:00:00Z\",\r\n            \"ShipName\": \"Ottilies K�seladen\",\r\n            \"ShipAddress\": \"Mehrheimerstr. 369\",\r\n            \"ShipCountry\": \"Germany\"\r\n        },\r\n        {\r\n            \"OrderID\": 10261,\r\n            \"CustomerID\": \"QUEDE\",\r\n            \"OrderDate\": \"1996-07-19T00:00:00Z\",\r\n            \"ShippedDate\": \"1996-07-30T00:00:00Z\",\r\n            \"ShipName\": \"Que Del�cia\",\r\n            \"ShipAddress\": \"Rua da Panificadora, 12\",\r\n            \"ShipCountry\": \"Brazil\"\r\n        },\r\n        {\r\n            \"OrderID\": 10262,\r\n            \"CustomerID\": \"RATTC\",\r\n            \"OrderDate\": \"1996-07-22T00:00:00Z\",\r\n            \"ShippedDate\": \"1996-07-25T00:00:00Z\",\r\n            \"ShipName\": \"Rattlesnake Canyon Grocery\",\r\n            \"ShipAddress\": \"2817 Milton Dr.\",\r\n            \"ShipCountry\": \"USA\"\r\n        },\r\n        {\r\n            \"OrderID\": 10263,\r\n            \"CustomerID\": \"ERNSH\",\r\n            \"OrderDate\": \"1996-07-23T00:00:00Z\",\r\n            \"ShippedDate\": \"1996-07-31T00:00:00Z\",\r\n            \"ShipName\": \"Ernst Handel\",\r\n            \"ShipAddress\": \"Kirchgasse 6\",\r\n            \"ShipCountry\": \"Austria\"\r\n        },\r\n        {\r\n            \"OrderID\": 10264,\r\n            \"CustomerID\": \"FOLKO\",\r\n            \"OrderDate\": \"1996-07-24T00:00:00Z\",\r\n            \"ShippedDate\": \"1996-08-23T00:00:00Z\",\r\n            \"ShipName\": \"Folk och f� HB\",\r\n            \"ShipAddress\": \"�kergatan 24\",\r\n            \"ShipCountry\": \"Sweden\"\r\n        },\r\n        {\r\n            \"OrderID\": 10265,\r\n            \"CustomerID\": \"BLONP\",\r\n            \"OrderDate\": \"1996-07-25T00:00:00Z\",\r\n            \"ShippedDate\": \"1996-08-12T00:00:00Z\",\r\n            \"ShipName\": \"Blondel p�re et fils\",\r\n            \"ShipAddress\": \"24, place Kl�ber\",\r\n            \"ShipCountry\": \"France\"\r\n        },\r\n        {\r\n            \"OrderID\": 10266,\r\n            \"CustomerID\": \"WARTH\",\r\n            \"OrderDate\": \"1996-07-26T00:00:00Z\",\r\n            \"ShippedDate\": \"1996-07-31T00:00:00Z\",\r\n            \"ShipName\": \"Wartian Herkku\",\r\n            \"ShipAddress\": \"Torikatu 38\",\r\n            \"ShipCountry\": \"Finland\"\r\n        },\r\n        {\r\n            \"OrderID\": 10267,\r\n            \"CustomerID\": \"FRANK\",\r\n            \"OrderDate\": \"1996-07-29T00:00:00Z\",\r\n            \"ShippedDate\": \"1996-08-06T00:00:00Z\",\r\n            \"ShipName\": \"Frankenversand\",\r\n            \"ShipAddress\": \"Berliner Platz 43\",\r\n            \"ShipCountry\": \"Germany\"\r\n        },\r\n        {\r\n            \"OrderID\": 10268,\r\n            \"CustomerID\": \"GROSR\",\r\n            \"OrderDate\": \"1996-07-30T00:00:00Z\",\r\n            \"ShippedDate\": \"1996-08-02T00:00:00Z\",\r\n            \"ShipName\": \"GROSELLA-Restaurante\",\r\n            \"ShipAddress\": \"5� Ave. Los Palos Grandes\",\r\n            \"ShipCountry\": \"Venezuela\"\r\n        },\r\n        {\r\n            \"OrderID\": 10269,\r\n            \"CustomerID\": \"WHITC\",\r\n            \"OrderDate\": \"1996-07-31T00:00:00Z\",\r\n            \"ShippedDate\": \"1996-08-09T00:00:00Z\",\r\n            \"ShipName\": \"White Clover Markets\",\r\n            \"ShipAddress\": \"1029 - 12th Ave. S.\",\r\n            \"ShipCountry\": \"USA\"\r\n        },\r\n        {\r\n            \"OrderID\": 10270,\r\n            \"CustomerID\": \"WARTH\",\r\n            \"OrderDate\": \"1996-08-01T00:00:00Z\",\r\n            \"ShippedDate\": \"1996-08-02T00:00:00Z\",\r\n            \"ShipName\": \"Wartian Herkku\",\r\n            \"ShipAddress\": \"Torikatu 38\",\r\n            \"ShipCountry\": \"Finland\"\r\n        },\r\n        {\r\n            \"OrderID\": 10271,\r\n            \"CustomerID\": \"SPLIR\",\r\n            \"OrderDate\": \"1996-08-01T00:00:00Z\",\r\n            \"ShippedDate\": \"1996-08-30T00:00:00Z\",\r\n            \"ShipName\": \"Split Rail Beer & Ale\",\r\n            \"ShipAddress\": \"P.O. Box 555\",\r\n            \"ShipCountry\": \"USA\"\r\n        },\r\n        {\r\n            \"OrderID\": 10272,\r\n            \"CustomerID\": \"RATTC\",\r\n            \"OrderDate\": \"1996-08-02T00:00:00Z\",\r\n            \"ShippedDate\": \"1996-08-06T00:00:00Z\",\r\n            \"ShipName\": \"Rattlesnake Canyon Grocery\",\r\n            \"ShipAddress\": \"2817 Milton Dr.\",\r\n            \"ShipCountry\": \"USA\"\r\n        },\r\n        {\r\n            \"OrderID\": 10273,\r\n            \"CustomerID\": \"QUICK\",\r\n            \"OrderDate\": \"1996-08-05T00:00:00Z\",\r\n            \"ShippedDate\": \"1996-08-12T00:00:00Z\",\r\n            \"ShipName\": \"QUICK-Stop\",\r\n            \"ShipAddress\": \"Taucherstra�e 10\",\r\n            \"ShipCountry\": \"Germany\"\r\n        },\r\n        {\r\n            \"OrderID\": 10274,\r\n            \"CustomerID\": \"VINET\",\r\n            \"OrderDate\": \"1996-08-06T00:00:00Z\",\r\n            \"ShippedDate\": \"1996-08-16T00:00:00Z\",\r\n            \"ShipName\": \"Vins et alcools Chevalier\",\r\n            \"ShipAddress\": \"59 rue de l'Abbaye\",\r\n            \"ShipCountry\": \"France\"\r\n        },\r\n        {\r\n            \"OrderID\": 10275,\r\n            \"CustomerID\": \"MAGAA\",\r\n            \"OrderDate\": \"1996-08-07T00:00:00Z\",\r\n            \"ShippedDate\": \"1996-08-09T00:00:00Z\",\r\n            \"ShipName\": \"Magazzini Alimentari Riuniti\",\r\n            \"ShipAddress\": \"Via Ludovico il Moro 22\",\r\n            \"ShipCountry\": \"Italy\"\r\n        },\r\n        {\r\n            \"OrderID\": 10276,\r\n            \"CustomerID\": \"TORTU\",\r\n            \"OrderDate\": \"1996-08-08T00:00:00Z\",\r\n            \"ShippedDate\": \"1996-08-14T00:00:00Z\",\r\n            \"ShipName\": \"Tortuga Restaurante\",\r\n            \"ShipAddress\": \"Avda. Azteca 123\",\r\n            \"ShipCountry\": \"Mexico\"\r\n        },\r\n        {\r\n            \"OrderID\": 10277,\r\n            \"CustomerID\": \"MORGK\",\r\n            \"OrderDate\": \"1996-08-09T00:00:00Z\",\r\n            \"ShippedDate\": \"1996-08-13T00:00:00Z\",\r\n            \"ShipName\": \"Morgenstern Gesundkost\",\r\n            \"ShipAddress\": \"Heerstr. 22\",\r\n            \"ShipCountry\": \"Germany\"\r\n        }\r\n    ]\r\n}";

            await HttpContext.Response.WriteAsync(json);

        }
    }
}