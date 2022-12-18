
# Backend Developer Case Study

## Soru 1)
Hızlı tüketim sektöründe faaliyet gösteren bir gıda firması, ürün ambalajları içerisine bir kod yerleştirerek, bu kodlar aracılığı ile çeşitli kampanyalar düzenlemek istemektedir. Proje aşağıda kısaca özetlenmiştir.

Öncelikle firmaya aşağıdaki özelliklere sahip 10.000.000 adet kod üretilecektir.
- Kodlar 8 hane uzunluğunda ve unique olmalıdır.
- Kodlar ACDEFGHKLMNPRTXYZ234579 karakter kümesini içermelidir.
- Kolayca tahmin edilememesi için ardışık sıralı üretim yapılmamalıdır.

Gıda firması kendisine iletilen kodları gerekli güvenlik önlemlerine dikkat edecek şekilde sadece yetkili kişilerin erişimine açacak ve gerekli matbaa süreçlerini yürütecektir.

Kampanya dönemi içerisinde ANDROID/IOS UYGULAMA, SMS, WEB, IVR gibi çeşitli kanallar üzerinden son kullanıcıların ellerindeki kodları kullanarak kampanyalara katılımı sağlanacaktır.
- Kod üretimi belirlediğiniz bir algoritmaya uygun olarak yapılmalıdır.
- Kod geçerliliği veritabanı, array, hash table, file, redis, elastic gibi bir ortamdan kontrol edilmemelidir.
- Kod geçerliliği sadece algoritmik olarak tespit edilmelidir.
- T-SQL ya da C# kullanabilirsiniz. Aşağıda T-SQL için procedure örnekleri verilmiştir.

![enter image description here](
https://i.ibb.co/qNQ0rpp/22-12-18-21-36-26.png
) 

## Soru 2)
Birden fazla dilde hizmet vermek üzere bir haber ajans sistemi tasarlanacaktır. Sistem multi-language destekli olarak tasarlanacak ve kullanıcının kullandığı dile uygun olarak içerikler istenen dilde servis edilecektir. Bu sistemde bir içerik için temelde aşağıdaki bilgilerin tutulması gerekmektedir.
- Name (Identifier olarak kullanılır, Multi Language olmasına gerek yok. Ingilizce yazılır)
- Title (Multi Language)
- Detail (Multi Language)
- ImageUrls (Multi Language, Bir içerik birden fazla imaja sahip olabilir)
- Category (Multi Language)
Kullanıcılar okumak istedikleri içerikler için web sitesi üzerinden desteklenen diller arasında bir seçim yapabilir, ardından da sisteme bu dil seçeneği ile birlikte istek atarak ilgili dil için girilmiş içerikleri listeleyebilirler.
Sisteme dil seçeneği ile istek geldiği durumda tasarladığınız yapıya uygun olarak içeriklerin verilmesini sağlayacak T-SQL sorgusunu yazmanız beklenmektedir. Aşağıda “en” ve “tr” dil seçenekleri ile yapılan örnek sorgu sonuçları verilmiştir.

![enter image description here](
https://i.ibb.co/B2BNDqf/carbon.png) 


## Soru 3)
Bir fiş tarama sistemi geliştirilecektir. OCR aşaması için SaaS bir sistem kullanılmaktadır.
Sistem Tanımı: Her fiş görseli için SaaS hizmetinden bir adet json response dönülmektedir. Json response içerisinde description ve ilgili description için koordinat bilgileri yer almaktadır. Amaç json’ın uygun şekilde parse edilerek fişe ait text’in görselde görünen haline en yakında halde kaydedilmesidir. Buna uygun olarak gerekli C# kodunu yazınız. Lütfen dikkat! Sizden OCR işlemi için bir çalışma yapmanız beklenmemektedir. Sadece verilen JSON’ın uygun şekilde parse edilmesi yeterlidir.

![enter image description here](
https://i.ibb.co/Thmxpd0/22-12-18-21-38-11.png) 
