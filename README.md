
<div align="center">
<h1>Onion Architecture<h1>
<img src="https://github.com/yilmazmustafayilmaz/MY.OnionArchitecture/blob/master/images/onionArchitecture.png" width="50%" height="50%">
</div>

<p>Temelinde (Presentation, Application, Persistence, Infrastructure, Domain) olmak üzere 5 ana katmandan oluşan bu mimari Jeffrey Palermo tarafından tanıtıldı. Klasik N-tier katmanlı mimarinin ileride oluşturacağı sorunlara çözüm sunan Onion mimariyi klasik mimariden ayıran en büyük fark Domain katmanını (Entity nesnelerini) tüm uygulamanın merkezi haline getirmesidir. Bu yaklaşım ile beraber test edilebilirlik, güvenilirlik ve sürdürülebilirlik daha da gelişmiştir. Böylece klasik mimarideki yaşanılan problemleri aşabilmemize ve olası değişiklik durumlarında daha az efor sarfedip hızlı bir çözüm sunmamıza yardımcı olur. Tüm bunlar yaşanırken uygulamanın katmanları arasında Gevşek bağlılık (Loose Coupling) oluşturmamızada olanak sağlar.</p>

<div align="center">
<img src="https://github.com/yilmazmustafayilmaz/MY.OnionArchitecture/blob/master/images/layers.jpg" width="40%" height="40%">
</div>

<h2>Application<h2>



