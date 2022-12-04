
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
<p>Code First uygulamada kullanılan veritabanı ile programlama dili arasında bir bağ oluşturur. Uygulamanın ihtiyacı olan veritabanı işlemlerini Visual Studio üzerinden gerçekleştirmemize imkan sağlayan bir yaklaşımdır. Code First yaklaşımı veritabanı işlemlerini veritabanı arayüzünü kullanmadan yada oldukça az ihtiyaç duyarak gerçekleştirmemizi amaçlar.</p><h2></h2>

<div align="center">
<h1>Generic Repository Pattern</h1>
</div>
<p>Bir yazılım projesinin olmazsa olmaz konusu olan Repository Pattern hakkında biraz konuşalım. Generic Repository Pattern adından da anlaşılacağı gibi genel bir repository yapısı kurmamızı sağlıyor. Bu ne demek derseniz ortak veritabanı işlemlerimiz için merkezi ve genel bir yapı kurup her bir modelin bu yapı üzerinden işlem gerçekleştirmesini sağlamaktır. Daha anlaşılır bir örnek vermek gerekirse oluşturduğumuz her veritabanı nesnemiz için ortak olan Create, Remove, Update, Delete (CRUD) işlemleri bulunmaktadır. Dont Repeat Yourself (DRY) prensibine uymak amacıyla bu CRUD işlemlerini her seferinde tekrarlamak yerine ortak bir repository sınıfı içerisinde oluşturup ihtiyaç dahilinde oluşturmuş olduğumuz sınıflarda kalıtım yoluyla kullanılmasıdır.</p>

