<div align="center">
<h2></h2>
<h1>Object Oriented Programming (Nesne Yönelimli Programlama)</h1>
</div>
<p>Object Oriented Programing (OOP) yazılım mantığını gözle görüp hissedebildiğimiz veri veya nesneler etrafında düzenleyen bir programlama dili modelidir. Gerçek hayatta gördüğümüz birçok nesnenin bilgisayar ortamına aktarılması yöntemidir. Bir nesnenin rengi, ismi, boyu, ağırlığı, üretim yılı, üretim yeri gibi birçok özelliklerinin bilgisayar ortamında gösterilmesi durumudur. 1960’larda ortaya çıkan bu programlama tekniği o dönemki geliştiricilerin çekmiş olduğu sıkıntılardan dolayı meydana çıkmıştır.</p>
<h2>Nesne Tabanlı Programlamanın Faydaları</h2>
<p>Nesneye yönelik programlama faktörleri gözetilerek inşa edilmiş bir programın üzerinde yapılacak bir değişiklik programın bütününde eş zamanlı bir şekilde gerçekleşir. Oluşturduğunuz nesnelerin yapıları birbirinden bağımsız olacağı için bilgi gizliliği sağlamış olursunuz. Programınızı oluştururken karşılaşacağınız süreç kısalır ve programın performansı artar. Oluşturmuş olduğunuz nesneleri herhangi bir sınıf içerisinde tüm özellikleri ile kullanma imkanınız olur. Gereksiz kod uzunluklarının önüne geçerek, daha önce oluşturmuş olduğunuz bir kod bloğunu her yerde kullanma imkanınız olur.</p>
<h2>Class (Sınıf)</h2>
<p>Değişkenlerin ve metotların bir arada tutulduğu yerdir.</p>
<h2>Object (Nesne)</h2>
<p>Verileri saklayan ve bu veriler üzerinde işlem yapan bileşendir.</p>
<h2>Nesne Yönelimli Programlamanın Özellikleri</h2>
<p>4 temel özellikden oluşur.
  <ul>
    <li>Soyutlama (Abstraction)</li>
    <li>Kapsülleme (Encapsulation)</li>
    <li>Miras Alma (Inheritance)</li>
    <li>Çok Biçimlilik (Polmorphism)</li>
  </ul>
</p>
<h2>Abstraction (Soyutlama)</h2>
<p>Nesneler, sadece diğer uygulamaların kullanımı ile ilgili olan ve gereksiz olan uygulama kodlarını gizleyen iç mekanizmayı ortaya çıkarır bu konsept geliştiricilerin de zaman içerisinde daha kolay ekleme ve değişiklik yapmalarına yardımcı olmaktadır.</p>
<h2>Encapsulation (Kapsülleme)</h2>
<p>Her bir nesnenin uygulanması ile durumu özel olarak tanımlanan bir sınır (scope) ya da sınıf içinde tutulmaktadır. Diğer nesneler de bu sınıfa ya da değişikliği yapma yetkisine sahip değil. Ancak sadece genel işlevler ya da yöntemler listesi çağırılabilir. Veri gizlemenin söz konusu bu özelliği daha çok program güvenliği sağlamaktadır ve istenmeyen verilerin bozulmalarını da önler.</p>
<h2>Inheritance (Miras Alma)</h2>
<p>Nesneler arasındaki ilişkiler ile alt sınıflar atanabilirler ve bu sayede geliştiricilerin benzersiz olan bir hiyerarşiyi korurken ortak mantığı da tekrar kullanmalarına izin verilir. Nesne yönelimli programlamanın bu özelliği daha da kapsamlı bir veri analizini zorlar ve geliştirme süresini azaltır, yüksek bir doğruluk düzeyini sağlar.</p>
<h2>Polmorphism (Çok Biçimlilik)</h2>
<p>Nesnelerin içeriğe de bağlı olarak birden çok forma girmesine izin verilir. Program, söz konusu kodun çoğaltılması gerekliliğini de azaltacak şekilde nesnenin her yürütülüşü için hangi kullanımın ya da anlamın gerekli olduğunu belirleyecektir.</p>

<div align="center">
<h2></h2>
<h1>Clean Code</h1>
</div>
<p>Clean Code (Temiz Kod) anlaşılır, degiştirilebilir ve geliştirilebilir koddur. Yazılan bir kodun bilgisayarlar tarafından anlaşılabildiği gibi başka geliştiriciler tarafından okunabilir ve geliştirilmeye açık olması gereklidir. Bir projeye yeni başlandığında geliştirme hızı yüksektir ama proje büyüdükçe hantallaşır ve karmaşıklaşmaya başlar yada geliştiriciler değiştikçe gelişim hızı yavaşlık gösterebilir bu tür aksaklıklar yaşanmasın diye Clean Code Prensibi meydana getirilmiştir.</p>
<h2>Clean Code Bize Ne Sağlar?</h2>
<p>
  <ul>
    <li>Metotların hangi amaçla kullanıldığı açıktır.</li>
    <li>Bir süre sonra koda tekrar bakılması gerektiğinde anlaşılabilirliği kolaydır.</li>
    <li>Başka geliştiricilerde kolaylıkla anlayabilir.</li>
    <li>Daha kolay test edilebilir.</li>
    <li>Tekrara düşmez.</li>
  </ul>
</p>
<h2>Genel Kullanım Kuralları</h2>
<p>
  <ul>
    <li>Kodu basit ve anlaşılabilir tut.</li>
    <li>Standart yaklaşımları uygula.</li>
  </ul>
</p>
<h2>Tasarım Kuralları</h2>
<p>
  <ul>
    <li>Bir sınıf doğrudan sadece bağımlılıklarını bilmelidir.</li>
    <li>Koşul ifadeleri kullanmak yerine polymorphism tercih edilmeli.</li>
    <li>Yapılandırılan veriyi kodun derinliklerinde değil daha kolay ulaşıp değiştirilebilen yerlerde bulundur.</li>
  </ul>
</p>
<h2>Anlaşılabilirlik Kuralları</h2>
<p>
  <ul>
   <li>Kullanmaya başladığın yöntemi değiştirme.</li>
   <li>Açık ve anlaşılır değişken isimleri kullan.</li>
   <li>Aynı sınıflar içerisinde başka şeylerle bağımlılığı olan metotlar yazmayın.</li>
  </ul>
</p>
<h2>İsimlendirme Kuralları</h2>
<p>
  <ul>
    <li>Açıklayıcı isimler kullanılmalı.</li>
    <li>İsimlendirme ile anlamlı ayrımlar oluşturun.</li>
    <li>Aradığınızda kolay ulaşılabilir isimlendirmeler yapın.</li>
  </ul>
</p>
<h2>Fonksiyon Kuralları</h2>
<p>
  <ul>
    <li>Küçük olmalı.</li>
    <li>Bir tek iş yapmalı.</li>
    <li>İsmi açıklayıcı olmalı.</li>
    <li>Olabildiğince az argüman almalı</li>
  </ul>
</p>
<h2>Yorum Satırı Kuralları</h2>
<p>
  <ul>
    <li>Gereksiz yorum kullanımından kaçının.</li>
    <li>Yorumu yazma sebebinizi anlaşılır dille açıklayın.</li>
    <li>Kodun açıklaması şeklinde yazın.</li>
  </ul>
</p>
<h2>Test Kuralları</h2>
<p>
  <ul>
    <li>Test okunabilir olmalıdır.</li>
    <li>Hızlı çalışır olmalıdır.</li>
    <li>Bağımsız olmalıdır.</li>
    <li>Test tekrar edilebilir olmalıdır.</li>
  </ul>
</p>
<h2>Code Smeells (Kodun Kötü Kokması)</h2>
<p>Bazen temiz kod kurallarına uyulmaya çalışılsa bile istenmeyen nedenlerden dolayı temiz kod kalitesinde yazamayız ve takımın deneyimsizliği, zamanın kısalığı, yönetimsel hatalar gibi sebeplerden dolayı kötü kod ortaya çıkar kodunuz ile ilgili bu tarz sinyaller alıyorsanız kodunuzda düzenlemeler yapmanız gerekir buna refactoring işlemi denir.</p>

<div align="center">
<h2></h2>
<h1>SOLID Prensipleri</h1>
</div>
<p>SOLID Prensipleri etkili, esnek ve doğru kodlama standartlarının sağlanması için takip edilen prensipler bütününe verilen addır. SOLID temel olarak 5 prensibin oluşturduğu baş harflerden meydana gelir.<br>Bunlar;
  <ul>
    <li>Single-responsibility principle</li>
    <li>Open-closed principle</li>
    <li>Liskov substitution principle</li>
    <li>Interface segregation principle</li>
    <li>Dependency inversion principle</li>
  </ul>
</p>
<h2>SOLID Prensiplerinin Amacı</h2>
<p>
  <ul>
    <li>Kodun güncelleme ve düzenlemelere kolayca adapte olması.</li>
    <li>Kod değişikliğini en kısa ve kolay seviyeye indirmek.</li>
    <li>Temiz kod yazmayı sağlamak.</li>
    <li>Karmaşık kodlardan kaçınmak.</li>
    <li>Kodu esnek bir şekilde kullanmak</li>
    <li>Yazılan kodu okuyan ve geliştiren her kişi tarafından yeterince anlaşılır kılmak</li>
  </ul>
</p>
<h2>Single Responsibility Principle</h2>
<p>Bu prensibe göre amaç bir sınıfın yalnızca tek bir sorumluluğu olmalıdır. Yazılımınızın içinde birden fazla görev yapan kısım olmamalıdır. Bu prensip, yazılım kodunda her bir sınıfın, modülün veya metodun yalnızca bir iş yapması gerektiğini savunur.</p>
<h2>Open Closed Principle</h2>
<p>Yazılan kodlar ekleme ve geliştirilme için açık ancak köklü değişiklikler için kapalı olmalıdır. Open Closed geniş çapta uygulanabilen ancak değişmeden kalan varlıklar gerektirir. Bu noktada çok biçimlilik (polymorphism) ile özel davranışlara sahip yinelenen varlıklar yaratmamız gerekir.</p>
<h2>Liskov Substitution Principle</h2>
<p>Bir programdaki nesneler o programın doğruluğunu değiştirmeden alt türlerinin örnekleriyle değiştirilebilir olmalıdır yani her alt sınıf, alt sınıfa özgü tüm yeni davranışlarla birlikte temel sınıftaki tüm davranışları korumalıdır. Alt sınıf, aynı istekleri işleyebilmeli ve üst sınıfıyla aynı görevleri tamamlayabilmelidir.</p>
<h2>Interface Segregation Principle</h2>
<p>İsteme özel birden fazla arayüz , tek bir genel amaçlı arayüzden daha iyidir. ISP’de sınıfların kullanmadıkları davranışları içermesi istenmez. ISP Sayesinde; Daha az kod taşıyan metotlar elde edilir. Kodun ihtiyaç durumunda güncellemesi hızlanır. Davranıştan bir metot sorumlu olduğu için davranışta karşılaşılan problem hızlı bir şekilde çözülür.</p>
<h2>Dependency Inversion Principle</h2>
<p>Sınıf ve doğru özellekliklerin sınıfa eklenmesi açısından en önemli Nesne Yönelimli Programla konularından biriside Abstraction (Soyulama) konusudur. Yüksek seviyeli modüller, düşük seviyeli modüllere bağlı olmamalıdır. Bunun yerine, her ikisi de abstraction veya interfacelere bağlı olmalıdır. Abstraction detaylara bağlı olmalıdır tam tersine detaylar soyutlamaya bağlı olmalıdır.</p>
<h2>SOLID Prensibleri Özetle</h2>
<p>
  <ul>
    <li><b>Single Responsibility:</b> Sınıflar iyi tanımlanmış tek bir sorumluluk almalı.</li>
    <li><b>Open/Closed:</b> Sınıflar değişikliğe kapalı geliştirilmeye açık olmalıdır.</li>
    <li><b>Liskov Substution:</b> Kodumuzda herhangi bir değişiklik yapmaya gerek kalmadan türetilmiş sınıfları ata sınıf yerine kullanabilmeliyiz.</li>
    <li><b>Interface Segregation:</b> Genel kullanım amaçlı tek bir arayüz yerine özelleşmiş birden çok arayüz oluşturma tercih edilmeli.</li>
    <li><b>Dependecy Inversion:</b> Katmanlı mimarilerde üst seviye modüller alt seviyedeki modüllere doğrudan bağımlı olmamalıdır.</li>
  </ul>
</p>

<div align="center">
<h2></h2>
<h1>Design Pattern (Tasarım Deseni)</h1>
</div>
<p>Konumuz Design Pattern (Tasarım Deseni) peki nedir bu tasarım desenleri. Günlük yaşantımız içinde istemeden birçok sorun ile karşılaşıyoruz ve bu sorunlar için çözümler arıyoruz kendi imkanlarımız içinde bulduğumuz bu çözümler kimi zaman işe yararken kimi zaman daha da güç durumlar oluşmasına sebep oluyor ancak işe yarayan çözümler sonradan oluşacak benzer problemler için bize önceden bir çözüm yolu sunuyor. Peki yazılım dünyasında problemlerimizden ders çıkarıp çözümler bulup bunları tekrarlamamak isteseydik ne olurdu?</p>
<h2>Design Pattern (Tasarım Deseni) Tarihçesi</h2>
<p>Design Pattern, yazılımcıların yazılım geliştirirken karşılaştıkları yada karşılaşabilecekleri sorunların genel çözümleridir. Yazılım tasarımında ortaya çıkan yaygın sorunlara karşı en basit biçimde yeniden kullanılabilir çözümler sağlar. Temelleri 1970 yılında ilk olarak mimarlar tarafından atılan, 1995 senesinde Dörtlü Çete tarafından yayınlanan kitap ile yaygınlaşan Design Pattern yazılım içerisinde kullanılmasında dönüm noktası olmuştur. Eric Gamma, Richard Helm, Ralph Johnson ve John Vlissides 1995’te “Design Patterns : Elements of Reusable Object — Oriented Software” kitabını çıkardılar. Bu dörtlü ayrıca “Gang of Four” olarak da bilinir. Bu dörtlü kitaplarında 3 kategoride 23 farklı kalıba yer vermişlerdir.</p>
<h2>Design Pattern Kategorileri</h2>
<p>Tasarım Desenleri genel olarak 3 ana başlıkta incelenir. Bunlar şunlardır:
  <ul>
    <li><b>Creational Patterns (Yaratımsal Desenler):</b> Nesnelerin oluşturulmasında ve yönetilmesinde kullanılan bir desendir. Bu program akışında hangi nesneye                                                               ihtiyaç varsa onu oluşturmada esneklik ve kolaylık sağlar.</li>
    <li><b>Structural Patterns (Yapısal Desenler):</b> Birden fazla sınıfın bir işi yerine getirirken nasıl davranacağını belirlemek için kullanılan desenlerdir.</li>
    <li><b>Behavioral Patterns (Davranışsal Desenler):</b> Nesnelerin birbirleri ile ilişkisini düzenleyen desendir.</li>
  </ul>
</p>
<h2>Creational Patterns (Yaratımsal Desenler)</h2>
<p>Creational Pattern (Yaratımsal Desenler) Bu tasarım deseni kendi içerisinde 5 gruba ayrılıyor.
  <ul>
    <li>Singleton Pattern</li>
    <li>Factory Pattern</li>
    <li>Abstract Factory Pattern</li>
    <li>Builder Pattern</li>
    <li>Prototype Pattern</li>
  </ul>
</p>
<h2>Structural Patterns (Yapısal Desenler)</h2>
<p>Structural Patterns (Yapısal Desenler) Bu tasarım deseni kendi içerisinde 8 gruba ayrılıyor.
  <ul>
    <li>Adapter Pattern</li>
    <li>Bridge Pattern</li>
    <li>Filter Pattern</li>
    <li>Composite Pattern</li>
    <li>Decorator Pattern</li>
    <li>Facade Pattern</li>
    <li>Flyweight Pattern</li>
    <li>Proxy Pattern</li>
    <li>Visitor Pattern</li>
  </ul>
</p>
<h2>Behavioral Patterns (Davranışsal Desenler)</h2>
<p>Behavioral Patterns (Davranışsal Desenler) Bu tasarım deseni kendi içerisinde 10 gruba ayrılıyor.
  <ul>
    <li>Command Pattern</li>
    <li>Interpreter Pattern</li>
    <li>Iterator Pattern</li>
    <li>Mediator Pattern</li>
    <li>Memento Pattern</li>
    <li>Observer Pattern</li>
    <li>Null Object Pattern</li>
    <li>Strategy Pattern</li>
    <li>State Pattern</li>
  </ul>
</p>

<div align="center">
<h2></h2>
<h1>Onion Architecture (Soğan Mimarisi)</h1>
<img src="https://github.com/yilmazmustafayilmaz/MY.OnionArchitecture/blob/master/images/onionArchitecture.png" width="50%" height="50%">
</div>
<p>Temelinde (Presentation, Application, Persistence, Infrastructure, Domain) olmak üzere 5 ana katmandan oluşan bu mimari Jeffrey Palermo tarafından tanıtıldı. Klasik N-tier katmanlı mimarinin ileride oluşturacağı sorunlara çözüm sunan Onion mimariyi klasik mimariden ayıran en büyük fark Domain katmanını (Entity Nesnelerini) tüm uygulamanın merkezi haline getirmesidir. Bu yaklaşım ile beraber test edilebilirlik, güvenilirlik ve sürdürülebilirlik daha da gelişmiştir. Böylece klasik mimarideki yaşanılan problemleri aşabilmemize ve olası değişiklik durumlarında daha az efor sarfedip hızlı bir çözüm sunmamıza yardımcı olur. Tüm bunlar yaşanırken uygulamanın katmanları arasında gevşek bağlılık (Loose Coupling) oluşturmamızada olanak sağlar.</p>
<div align="center">
<img src="https://github.com/yilmazmustafayilmaz/MY.OnionArchitecture/blob/master/images/layers.jpg" width="40%" height="40%">
</div>
<h2>Application</h2>
<p>Application katmanı, Domain katmanında bulunan veritabanı nesnelerinin CRUD işlemlerinin arayüzünün (Interface) tutulduğu katmandır. Burada amaç gevşek bağlı (Loose Coupling) bir sistem oluşturmaktır.</p>
<h2>Domain</h2>
<p>Domain katmanı, uygulamanın merkezinde bulunan katmandır. Bu katmanda bütün veritabanı nesnelerimiz bulunmaktadır.</p>
<h2>Infrastructure</h2>
<p>Infrastructure katmanı bir altyapı katmanı olarakda kullanılabilmekte aynı zamanda uygulama içerisinde kullanılacak veritabanı işlemi gerektirmeyen dış kaynak servislerin eklendiği katmandır. Örnek resimde görüldüğü gibi en dış katmanda bulunduğu için başka bir iç katman tarafından referans işlemi olmamalıdır.</p>
<h2>Persistence</h2>
<p>Persistence katmanı, veritabanı ile ilgili işlemerimizi (Context, Migration, Configuration) gerçekleştirdiğimiz katmandır. Buna ek olarak Application katmanında bulunan arayüzlerinde (Interface) bu katmanda implement işlemleri gerçekleştirilir.</p>
<h2>Presentation</h2>
<p>Presentation katmanı, bu katmanda projenin kullanıcı ile nasıl iletişime geçeceğini belirliyoruz (Web App, Web Api, Mvc, Console App)</p><h2></h2>

<div align="center">
<h1>Entity Framework Core</h1>
<img src="https://github.com/yilmazmustafayilmaz/MY.OnionArchitecture/blob/master/images/entityFrameworkCore.png" width="50%" height="50%">
</div>
<p>Entity Framework Core (EF Core), Entity Framework veri erişim teknolojisinin basit, genişletilebilir, açık kaynak ve platformlar arası bir sürümüdür. EF Core nesne ilişkisel bir eşleyici (ORM) aracı olarak görev yapabilir. DotNet geliştiricilerinin .Net nesnelerini kullanarak bir veritabanıyla çalışmasını sağlar. Aynı zamanda EF Core birden fazla veritabanı altyapısını destekler</p>
<h2>Object-Relational Mapping (ORM)</h2>
<p>Uygulama geliştirirken hiç şüphesiz ihtiyaç duyduğumuz şeylerden birisi veritabanı bağlantısı oluşturmaktır. Ancak bu bağlantıyı oluştururken bunun yönetiminide kullandığımız dilin yapısı ile yapmayı tercih ederiz işte tam bu noktada yardımımıza ORM araçları yetişiyor ve kod içerisindeki sql komutlarını ortadan kaldırıyor. Veritabanımızda bulunan tablolara karşılık bir sınıf, kolonlardaki alanlara karşılık gelecek property oluşturuyor bununla beraber veritabanındaki bulunan kayıtlarımızada ait olduğu sınıfta bir obje olarak erişebilmemize olanak sağlıyor. ORM sanal olarak veritabanındaki bir tablonun ona karşılık oluşturulan bir nesne ile eşleşmesidir.</p>
<h2>Fluent Api</h2>
<p>Entity Framework Core konusundan bahsetmişken Fluent Api hakkında da birkaç bişey yazmak istedim ve uygulama içerisinde bir örnek verdim. Fluent Api, Entity Framework Code First yapısını kullandığımızda veri tabanı sınıflarımızın özellikleri ve bu sınıflarımızın ilişkilerini oldukça geniş bir şekilde yapılandırabilmemize olanak sağlayan bir yapıdır.</p>
<div align="center">
<img src="https://github.com/yilmazmustafayilmaz/MY.OnionArchitecture/blob/master/images/fluentApi1.jpg" width="40%" height="40%">
<img src="https://github.com/yilmazmustafayilmaz/MY.OnionArchitecture/blob/master/images/fluentApi2.jpg" width="40%" height="40%">
</div>
<h2>Code First</h2>
<p>Code First uygulamada kullanılan veritabanı ile programlama dili arasında bir bağ oluşturur. Uygulamanın ihtiyacı olan veritabanı işlemlerini Visual Studio üzerinden gerçekleştirmemize imkan sağlayan bir yaklaşımdır. Code First yaklaşımı veritabanı işlemlerini veritabanı arayüzünü kullanmadan yada oldukça az ihtiyaç duyarak gerçekleştirmemizi amaçlar.</p>
<h2>Table Per Type</h2>
<p>Table Per Type (TPT) Entityler arasında oluşan kalıtımsal ilişki durumunda ortaya çıkan bir davranış modelidir. Bu model ile birlikte veritabanında bulunan bir tablodaki belirli kolonların kendisinden kalıtım almış olan diger tablolarda birebir ilişki ile tutulmasıdır. Bunun ne demek olduğunu daha iyi anlamak için gerçek hayat ile ilişkili küçük bir örnek düşünelim. Bir bisiklet dükkanında 2 farklı bisiklet çeşidi bulunsun bunu veritabanında modellediğimizi düşünürsek birbirini tekrar eden alanları Bisikletler isminde dükkandaki bütün bisikletlerin kaydını tutacak bir tabloda tutarız ve bu base (temel) class'dan kalıtım alan indirimli ve ikinci el derived (türetilmiş) class'lar oluştururuz. Bu sayede her bisiklette bulunması gereken kolonların tekrarından kaçınırız aynı zamanda bu durum aralarında mantıksal bir kalıtım işlemi olduğu anlamınada gelir.</p>
<div align="center">
<img src="https://github.com/yilmazmustafayilmaz/MY.OnionArchitecture/blob/master/images/TablePerType.jpg" width="40%" height="40%">
</div>
<h2>Table Per Hierarchy</h2>
<p>Table Per Hierarchy (TPH) Entityler arasında oluşan kalıtımsal ilişki durumunda ortaya çıkan bir diğer davranış modelidir. TPH davranış modelinde birbiri ile kalıtımsal hiyerarşi içinde bulunan tüm veritabanı nesneleri için veritabanında tek tablo oluşturulur. Veriler tutulurken base (temel) class içerisinde bulunan alanlar ve işlemi gerçekleştirdiğimiz derived (türetilmiş) class içindeki alanlar doldurulurken diger alanlar null şekilde bırakılır. Peki derived (türetilmiş) class'ları birbirinden nasıl ayırt ediyoruz işte burada EF Core tabloya Discriminator (Ayrımcı) adında bir alan daha ekliyor. Şimdi TPH davranış modelini de daha iyi anlamak için gerçek hayat örneği oluşturalım. Telefon ve tablet satışı yapan bir dükkanda tüm marka ve özelliklerin tutulduğu bir veritabanı modelleyelim bize lazım olan bir adet base (temel) class bu sınıf içerisinde satıcı bilgisi tutuyor olsun ve bu sınıftan kalıtım alan 2 tane derived (türetilmiş) class oluşturalım böylece elimizde 3 tane veritabanı nesnesi olduğu halde TPH davranış modeli bizim için bunları veritanında tek bir tablo halinde tutacaktır.
Peki bu bize ne sağlar;
<ul>
  <li>Tüm veriler tek bir tabloda saklandığından CRUD işlemlerinde yüksek performans.</li>
  <li>Veritabanındaki minimum tablo sayısı.</li>
</ul>
Proje içerisinde FileUpload yapısı Table Per Hierarchy (TPH) davranış modeli kullanılarak yapılmıştır.
</p><div align="center">
<img src="https://github.com/yilmazmustafayilmaz/MY.OnionArchitecture/blob/master/images/tablePerHierarchy.jpg" width="40%" height="40%">
</div><h2></h2>

<div align="center">
<h1>Generic Repository Pattern</h1>
</div>
<p>Bir yazılım projesinin olmazsa olmaz konusu olan Repository Pattern hakkında biraz konuşalım. Generic Repository Pattern adından da anlaşılacağı gibi genel bir repository yapısı kurmamızı sağlıyor. Bu ne demek derseniz ortak veritabanı işlemlerimiz için merkezi ve genel bir yapı kurup her bir modelin bu yapı üzerinden işlem gerçekleştirmesini sağlamaktır. Daha anlaşılır bir örnek vermek gerekirse oluşturduğumuz her veritabanı nesnemiz için ortak olan Create, Read, Update, Delete (CRUD) işlemleri bulunmaktadır. Dont Repeat Yourself (DRY) prensibine uymak amacıyla bu CRUD işlemlerini her seferinde tekrarlamak yerine ortak bir repository sınıfı içerisinde oluşturup ihtiyaç dahilinde oluşturmuş olduğumuz sınıflarda kalıtım yoluyla kullanılmasıdır.</p>
<div align="center">
<img src="https://github.com/yilmazmustafayilmaz/MY.OnionArchitecture/blob/master/images/genericRepositoryPattern.jpg" width="40%" height="40%">
</div><h2></h2>

<div align="center">
<h1>Command Query Responsibility Segregation</h1>
</div>
<p>Command Query Responsibility Segregation (CQRS) pattern adından da anlaşılacağı gibi Command ve Query operasyonlarının birbirinden ayrılmasını savunan bir tasarım desenidir. Peki nedir bu Command ve Query operasyonları. Geliştirmiş olduğumuz projeye temelde iki çeşit istek yapılır bunlardan sistemde hiç bir değişiklik yapmadan sadece okuma/read işlemi yapanlara Query (GetAll, GetById), sistemde herhangi bir değişikliğe yol açan yeni bir veri ekleme, var olan veri üzerinde değişiklik yapma yada var olan veriyi silme gibi yazma/write işlemlerinede Command (Insert, Update, Delete) denir.
Avantajları;
<ul>
  <li>CQRS, okuma ve yazma işlemlerinin birbirinden ayrılması iş yüklerinin bağımsız olarak ölçeklendirilebilmesine olanak tanır.</li>
  <li>Read ve write işlemleriniz için farklı veritabanları kullanabilirsiniz.</li>
  <li>Read ve write işlemleri birbirinden ayrıldığı için, herhangi yapılacak bir read işleminde write işlemini beklemek zorunda kalmayız.</li>
</ul>
</p>
<div align="center">
<img src="https://github.com/yilmazmustafayilmaz/MY.OnionArchitecture/blob/master/images/CqrsPattern.png" width="60%" height="40%">
</div><h2></h2>

<div align="center">
<h1>Mediator Design Pattern</h1>
</div>
<p>Mediator birden çok nesne veya sınıf arasındaki iletişim karmaşıklığını azaltmak için kullanılır. Bu pattern, normalde farklı sınıflar arasındaki tüm iletişimleri yöneten ve gevşek bağlantıyla kodun kolay bakımını destekleyen bir arabulucu sınıfı sağlar. Mediator pattern Behavioural Pattern (Davranışsal Desenler) kategorisine girer.
Temel olarak Mediator iki işlem gerçekleştirir.
<ul>
  <li>Gelen talebi işler ve yanıt sağlar.</li>
  <li>Gelen isteği kabul eder.</li>
</ul>
Şimdi daha iyi anlamak için gerçek hayat senaryosu düşünelim. Mediator pattern denince akla gelen ilk örnek tabi ki uçak ve kule örneğidir. Piste iniş yapacak yada kalkış gerçekleştirecek uçakların olası bir sorun yaşamamak için birbirleri ile haberleşmesi gerekmektedir. Şartlar uygun ve pist alanında başka uçak yok ise iniş yada kalkış gerçekleştirmektedirler. Uçaklar kendi aralarındaki bu iletişimi kule üzerinden gerçekleştirirler. Çünkü birbirleri ile iletişime geçmeleri halinde büyük bir karmaşıklık oluşacaktır. İletişim görevini kule üstlenerek bu oluşması muhtemel karmaşıklık ortadan kaldırmış olur.
</p>
<div align="center">
<img src="https://github.com/yilmazmustafayilmaz/MY.OnionArchitecture/blob/master/images/mediator.png" width="40%" height="40%">
</div><h2></h2>

<div align="center">
<h1>AutoMapper</h1>
</div>
<p>AutoMapper birbirinden farklı tipteki complex objeleri birbirine otomatik bir şekilde dönüştürmeye yardımcı olan kütüphanedir. Kodun kirli görüntüsünden bizi kurtararak birden fazla satırda objenin her bir elemanını tek tek birbirine dönüştürmek yerine tek satırda objenin kendisini dönüştürmemize olanak sağlayarak fazla satır ile kodun kötü görünmesini engeller</p><h2></h2>

<div align="center">
<h1>Fluent Validation</h1>
</div>
<p>Bir yazılım geliştirici olarak yazdığımız kodun çalışması bizim için yeterli değildir, aynı zamanda sistemin düzgün ve kararlı bir çalışma göstermesini isteriz. Bu kararlılığı sağlamak için validasyon (doğrulama) işlemlerini kullanırız. Küçük sistemlerde if-else sorguları yada kendi yazdığımız basit yapıları kullanabiliyorken proje içeriği büyüdükçe işler daha da zorlaşabiliyor. Bu nedenle Fluent Validation kütüphanesinden yardım alıyoruz. Fluent Validation bir veri doğrulama kütüphanesidir. Verilere doğru şekilde kısıtlamalar eklenmesini sağlayarak kurallara uygun ve kullanıcı kaynaklı hataların önüne geçilmesinde bize yardımcı oluyor aynı zamanda birden çok if-else sorgusu yazmamıza gerek kalmadığı için kodun daha okunaklı ve anlaşılabilir olmasını sağlıyor.</p>
<div align="center">
<img src="https://github.com/yilmazmustafayilmaz/MY.OnionArchitecture/blob/master/images/fluentValidation1.jpg" width="40%" height="40%">
<img src="https://github.com/yilmazmustafayilmaz/MY.OnionArchitecture/blob/master/images/fluentValidation2.jpg" width="40%" height="40%">
</div><h2></h2>

<div align="center">
<h1>Identity</h1>
<img src="https://github.com/yilmazmustafayilmaz/MY.OnionArchitecture/blob/master/images/identity.png" width="60%" height="50%">
</div>
<p>Microsoft dokümantasyonu içerisinde Identity yapısını şöyle tanımlanıyor:
  <ul>
    <li>Kullanıcı arayüzü (UI) giriş işlevini destekleyen bir API</li>
    <li>Kullanıcıları, şifreleri, profil verilerini, rolleri, istekleri, tokenları, e-posta onayını ve daha fazlasını yönetir.</li>
  </ul>
Identity kullanıcı yönetim sisteminin olmazsa olmazlarındandır. Kullanıcının sisteme girişi (Authentication) ve kullanıcının sistem içerisindeki yetkileri (Authorization) geliştiriciler tarafından yönetilmesi gereken önemli bir konudur.
</p>
<h2>Authentication</h2>
<p>Authentication (Kimlik Doğrulama) bir kullanıcının sisteme giriş yetkisinin olup olmadığının kontrol edilmesi işlemidir.</p>
<h2>Authorization</h2>
<p>Authorization (Kimlik Yetkilendirme) sistemde var olan kullanıcının hangi yetkilere sahip olduğunun belirlenmesidir.</p>
<h2>Role</h2>
<p>Role sisteme giriş yapan bir kullanıcının hangi rollere sahip olduğunu ve bu rollerin kullanıldığı yerlerde kontrol sağlayan yapıdır.</p>
<h2>Claims</h2>
<p>Claims sisteme giriş yapan kullanıcının kendisine ait bilgilerinin tutulduğu yapıdır Örneğin; email, username, doğrulama sorusu Claims ile tutulan bilgilerden bazılarıdır.</p>
<h2>Third Party Authentication</h2>
<p>Third Party Authentication (Üçüncü taraf kimlik doğrulamadır) kullanıcının aktif olarak oluşturmuş olduğu sosyal medya kanalları ile giriş yapabilmesidir. Örneğin Facebook, Twitter, Google</p>

<div align="center">
<h1>Log</h1>
</div>
<p>Loglama, bir sistem üzerinde gerçekleştirilen işlemlerin kayıt altında tutulmasıdır. Örnek verecek olursak sisteme kim giriş yaptı? Sistemi kim kullanıyordu? Hata kodu nedir? Ne zaman gerçekleşti? Uygulama neden başarısız oldu? gibi kayıtlar oluşturmamızı sağlar. Loglar aynı zamanda uygulamanın runtime'da yaşadığı problemleri yönetebilmemiz konusunda da bize kolaylık sağlar.</p>
<h2>Serilog</h2>
<p>Serilog, sistemdeki logları console, file, database vb. aktarmamızı sağlayan bir kütüphanedir. Serilog kütüphanesini diğer log kütüphanelerinden ayıran durum oldukça kullanışlı bir şekilde yapılandırılmış günlük kaydı (Structed Logging) özelliğidir. Ayrıca performans konusunda da çok başarılı bir log kütüphanesidir.</p>
<h2>Structured Logging</h2>
<p>Structured Logging, bir veriyi nesne yapısında loglama ve bu yapısal veriyi kolay bir şekilde sorgulama işlemidir diyebiliriz.</p>

<div align="center">
<h1>SignalR</h1>
</div>
<p>SignalR, açık kaynak kodlu bir .Net kütüphanesidir, gerçek zamanlı çalışan uygulamalar geliştirmek için kullanılır. Http bağlantılarında client ile server arasındaki iletişim her istek yapıldığında yenilenirken, SignalR ile client ve server arasında sürekli bir bağlantı oluşturulur. Bunu daha iyi anlamak için şu iki kıyası yapabiliriz. Bir veri üzerinde değişiklik yapmak istedeğimizde Http protokolü vasıtasıyla bu işlemi gerçekleştirmiş olsaydık bu güncellemenin görüntülenmesi için sayfayı yenilemek durumunda kalırdık. Ancak SignalR kütüphanesinde bulunan Remote Procedure Calls (RPC) özelliği ile bir veride değişiklik olduğunda server bir javascript (js) kodu çağırarak bunu Client'lara haber verir. Bu sayede gerçek zamanlı olarak çalışan uygulamalar elde edebiliriz.</p>
