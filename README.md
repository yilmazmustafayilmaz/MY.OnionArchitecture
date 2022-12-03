
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
<img src="https://github.com/yilmazmustafayilmaz/MY.OnionArchitecture/blob/master/images/onionArchitecture.png" width="50%" height="50%">
</div>


