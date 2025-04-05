# ÖDEV2

## WEB HABERLEŞME TEKNOLOJİLERİ

#### WEB HABERLEŞME TEKNOLOJİLERİ NEDİR?

Web haberleşme teknolojileri, internete bağlı cihazlar arasında veri alışverişi yapılmasını sağlayan protokol, yöntem ve araçların bütünüdür. Bu teknolojiler, tarayıcı ile web sunucusu arasında ya da farklı sistemler arasında bilgi alışverişini mümkün kılar. 

#### PEKİ BU TEKNOLOJİLERİN AMAÇLARI NELERDİR?

##### 1.Veri iletimini sağlamak 
Kullanıcıların yaptığı işlemlerin(arama, form gönderme, veri görüntüleme) sunucuya ulaşmasını sağlar. 
##### 2.İletişim standartlarını belirlemek
Tüm sistemlerin anlayabileceği standart bir dil oluşturur. 
##### 3. Performans ve güvenlik yönetimi
Hızlı ve güvenli veri alışverişi için çeşitli protokoller ve yöntemler kullanılır. 
##### 4.Gerçek zamanlı iletişim
Canlı sohbet, oyunlar, bildirimler gibi anlık veri iletimine imkan tanır. 

#### Peki bu teknolojilerin temel bileşenleri nelerdir? 

##### 1.İstemci(Client)
Kullanıcının cihazı (bilgisayar, telefon) ve üzerinde çalışan tarayıcı veya uygulamardır. 

Genellikle veri talep eden taraftır. 
##### 2.Sunucu(Server)
Verileri sağlayan sistem. Genellikle bir web sunucusu veya API sunucusudur. 

İstemciden gelen istekleri işler ve yanıt verir. 
##### 3.Protokoller
Haberleşmenin kurallarını belirler (örneğin HTTP, WebSocket, gRPC). 
##### 4.Veri Formatları
Gönderilen verinin yapısını belirler: JSON, XML, Protobuf, vs.

####  Peki bu sistemler nasıl çalışır? 

1-)İstemci, bir istekte bulunur (örneğin bir web sayfasını açmak). 

2-)Bu istek, belirli bir protokol (örneğin HTTP) üzerinden sunucuya iletilir. 

3-)Sunucu, isteği işler, yanıt hazırlar (örneğin bir HTML sayfası veya JSON veri). 

4-)Yanıt, aynı protokol üzerinden istemciye geri döner. 

5-)İstemci bu yanıtı işler ve kullanıcıya sunar. 

#### Peki temel haberleşme protokolleri nelerdir?

##### 1.HTTP (HyperText Transfer Protocol) 
İstemci-sunucu modeline dayanır. 

En yaygın kullanılan protokoldür. 

Metotlar: GET, POST, PUT, DELETE, PATCH 

Stateless: Sunucunun durumuyla ilgilenmeden iletişime geçmektir. 
##### 2.HTTPS (HTTP Secure) 
HTTP’nin SSL/TLS ile şifrelenmiş versiyonudur. 

Kimlik doğrulama ve veri bütünlüğü sağlar. 

Modern webde varsayılan hale gelmiştir. 
##### 3.WebSocket 
Tarayıcı ve sunucu arasında sürekli açık bir bağlantı kurar. 

Gerçek zamanlı uygulamalar için idealdir (ör. sohbet, oyun, canlı veri akışı). 

Full-duplex (çift yönlü) iletişim. 

Web iletişimini sağlamak için sunucuda  açık tutulan porttur. 
##### 4.REST (Representational State Transfer) 
HTTP üzerinde çalışan mimari stil. 

Kaynaklar URI ile tanımlanır. 

JSON, XML gibi veri formatları kullanılır. 

Hafif, okunabilir, yaygın. 

Kullanıcıyla sunucu arasındaki köprü görevi sağlar. 
##### 5.SOAP (Simple Object Access Protocol) 
XML tabanlı protokoldür. 

Katı standartlara ve güvenlik yapısına sahiptir. 

Genellikle kurumsal sistemlerde tercih edilir. 

WS-Security, WS-ReliableMessaging gibi ek standartlar içerir. 

Farklı yazılım sistemlerinin birbiriyle güvenli ve standart bir şekilde iletişimini sağlar. 
##### 6.GraphQL 
Facebook tarafından geliştirilmiştir. 

İstemcinin sadece ihtiyaç duyduğu veriyi çekmesini sağlar. 

Karmaşık ilişkili verilerde REST’e göre daha esnektir. 

Tek bir endpoint üzerinden çalışır. 

Veri kalabalığından kurtarır. 
##### 7.gRPC(Google Remote Procedure Call) 
HTTP/2 tabanlıdır, Protobuf kullanır. 

Performansı yüksek, binary veri formatında çalışır. 

Mikroservisler arası iletişimde idealdir. 

Farklı sistemler arasında hızlı, verimli ve güvenilir iletişim sağlayan bir protokoldür. 
##### 8.Server-Sent vents (SSE) 
Sunucudan istemciye tek yönlü sürekli veri akışı sağlar. 

WebSocket’in basit alternatifi, genellikle bildirimlerde kullanılır. 

Sayfa yenilenmeden anlık verilerin otomatik olarak güncellenmesini sağlar. 

#### Peki veri formatları nelerdir?

##### JSON (JavaScript Object Notation)
Hafif, okunabilir ve REST/GraphQL'de yaygın, Genellikle web uygulamaları, API'ler ve mobil uygulamalar arasında veri paylaşımında kullanılır. JSON, verilerin kolayca okunmasını ve işlenmesini sağlar.
##### XML (eXtensible Markup Language)
SOAP ve eski sistemlerde sık kullanılır, XML verilerin düzenli bir şekilde saklanmasını ve farklı sistemler arasında taşınmasını sağlar. Günlük yaşamda, web siteleri, e-ticaret platformları, kütüphaneler ve yazılımlar gibi birçok alanda veri paylaşımı ve düzeni için kullanılır. 
#####  Protobuf (Protocol Buffers)
gRPC'de kullanılır, hızlı ve sıkıştırılmış, Protobuf, veriyi daha küçük ve hızlı bir şekilde iletmek için kullanılan bir format olup, genellikle ağ trafiğini azaltmak ve sistemlerin daha hızlı çalışmasını sağlamak için tercih edilir.
##### YAML
Konfigürasyon ve bazı API veri tanımlamalarında, YAML verilerin okunabilir bir formatta düzenlenmesini sağlayan bir işaretleme dilidir. Genellikle yazılım konfigürasyon dosyalarında, CI/CD süreçlerinde, oyun ve uygulama veri yapılarında, konteyner yönetimi gibi alanlarda kullanılır. Kullanıcı dostu olması sayesinde verileri hızlıca düzenlemeyi ve anlamayı kolaylaştırır.

#### Peki mimari yapılar nelerdir?

##### 1.İstemci-Sunucu (Client-Server) 
Geleneksel modeldir. 

Tarayıcı, sunucuya istek gönderir, sunucu cevap döner. 

İstemci-sunucu mimarisi, istemcilerin hizmet talep ettiği, sunucuların ise bu talepleri işleyip cevap verdiği bir modeldir. 
##### 2.RESTful Mimari 
Kaynak odaklıdır. 

CRUD (Create, Read, Update, Delete) işlemleri HTTP metotlarıyla eşleşir. 

RESTful mimari, HTTP protokolü üzerinden veri transferi yaparak kaynaklara (verilere) ulaşmayı sağlayan bir yapıdır. RESTful sistemlerde, veri genellikle JSON veya XML formatında iletilir ve HTTP metodları (GET, POST, PUT, DELETE) kullanılarak işlem yapılır. Bu yapı, verimli, esnek ve ölçeklenebilir bir iletişim sağlar. 
##### 3.Mikroservis Mimarisi 
Uygulama bağımsız servislerden oluşur. 

Servisler arasında haberleşme için REST, gRPC, mesaj kuyrukları (RabbitMQ, Kafka) kullanılır. 

Mikroservis mimarisi, büyük ve karmaşık sistemleri bağımsız çalışan, küçük ve spesifik mikroservislere böler. Her mikroservis, tek bir işlevi yerine getirir ve birbirleriyle API'ler aracılığıyla iletişim kurar. Bu yapı, her mikroservisin bağımsız olarak geliştirilmesi, dağıtılması ve ölçeklenmesi için esneklik sağlar, ayrıca sistemin yönetilmesini ve bakımını kolaylaştırır. 
##### 4.Gerçek Zamanlı Uygulama Mimarisi 
WebSocket, SSE veya MQTT gibi sürekli bağlantı teknolojileri kullanılır. 

Oyunlar, canlı bildirimler, veri panoları gibi uygulamalar için idealdir. 

Gerçek zamanlı mimari, verilerin hızlı bir şekilde işlendiği ve tepki verildiği bir yapıdır. Bu mimari, gecikmesiz veri işleme gerektiren uygulamalarda kullanılır. Örnek olarak, çevrimiçi oyunlar, canlı yayınlar, finansal işlemler ve trafik yönetimi gibi sistemler, gerçek zamanlı mimari ile anlık veri işleyerek hızlı ve kesintisiz bir deneyim sunar. 

#### Peki güvenlik unsurları nelerdir?

##### SSL/TLS
HTTPS ile şifreli bağlantı, SSL/TLS, internet üzerinde veri güvenliğini sağlamak için kullanılan şifreleme protokolleridir. Bu protokoller, kullanıcı adı, şifre, kredi kartı bilgileri gibi hassas verilerin üçüncü kişiler tarafından ele geçirilmesini engeller, böylece internet üzerinden yapılan iletişimin güvenliğini sağlar.
##### JWT (JSON Web Token)
Kimlik doğrulama ve yetkilendirme, JWT, internet üzerinden güvenli iletişim ve kimlik doğrulama için kullanılan bir token standardıdır. Kullanıcı bir uygulamaya giriş yaptıktan sonra, sunucu bir JWT oluşturur ve bunu kullanıcıya gönderir. Bu token, sonraki tüm isteklerde kullanıcıyı doğrulamak için kullanılır. JWT, şifreli değildir ancak imzalanır, böylece veri doğruluğu sağlanır. Ayrıca, kimlik doğrulama ve yetkilendirme işlemleri için güvenli bir çözüm sunar.
##### OAuth2
Üçüncü taraf servislerle güvenli bağlantı, OAuth2, kullanıcıların üçüncü taraf uygulamalara, şifrelerini vermeden, belirli verilere erişim izni vermesini sağlayan bir güvenlik protokolüdür. Kullanıcılar, OAuth2 sayesinde sosyal medya hesapları, ödeme sistemleri veya diğer platformlarda şifrelerini paylaşmadan yalnızca izin verdikleri verilere erişim sağlar. Bu, güvenli ve sınırlı erişim imkanı sunarak, veri güvenliğini artırır.
##### CORS
Tarayıcılar arası kaynak paylaşımı kontrolü, CORS, web tarayıcılarının farklı kaynaklardan gelen isteklere güvenli bir şekilde izin verip vermediğini kontrol eden bir güvenlik mekanizmasıdır. Web uygulamaları, genellikle başka domain'lerde barındırılan API'lerle etkileşimde bulunur. CORS, yalnızca doğru izinleri sağlayan kaynakların bu verilere erişmesine olanak tanır. Böylece, kötü niyetli sitelerin, kullanıcıların verilerini çalmaları veya kötüye kullanmalarının önüne geçilir. 
##### Rate Limiting
Saldırılara karşı koruma, Rate limiting, bir kaynağa yapılan istek sayısını belirli bir süre içinde sınırlayan bir güvenlik önlemidir. Bu, sistemin aşırı yüklenmesini engeller, kötü niyetli saldırıları zorlaştırır ve kaynakların adil kullanılmasını sağlar. Örneğin, bir API'ye yapılan istek sayısı, aynı IP adresinden yapılan giriş denemeleri veya SMS/e-posta doğrulama talepleri sınırlanarak, sistemin güvenliği ve performansı korunur.
