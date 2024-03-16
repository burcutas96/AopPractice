# Aop Nedir?

<p>
Aspect-oriented programming (AOP), bir başka deyişle cepheye-yönelik programlama kulağa oldukça karmaşık gelen teknik bir kavram. Fakat algılandığı kadar karmaşık değil. Aop tekniği yazılımcılara basmakalıp ve tekrar eden kod bloklarını kopyalayıp yapıştırmaktan daha fazla zaman kazandıran ve bu konuda geliştiricileri destekleyen bir programlama tekniğidir. Aop bunu yaparken hem kod bloklarının okunabilirliğini arttırır hem de projelerinize değer katar. Temelde Aop ile kod bloklarına ilişkin olarak:
</p>

* Temiz kod blokları elde edilir. (clean code)
* Kod bloklarını okumak kolaylaşır. (easier to read)
* Hatalara daha az açıktır. (less prone to bugs)
* Sürdürülmesi daha kolaydır. (easier to maintain)
* Tekrarları azaltır. (reduce repetetion)
* Test süreçlerini iyileştirir. (test process optimization)

<p>
Aop kullanmanın temel niyeti logging, caching ve transaction gibi kesişen kaygıların (cross-cutting concerns) veya fonksiyonel olmayan gereksinimlerin yönetimidir. Kes, kopyala ve yapıştırın ötesinde; Proxy pattern ya da Decorator pattern gibi yapıları kullanarak kesişen endişeler güvenle yönetilebilir.
</p>

<p>
Aop gerçekleştirmek üzere; PostSharp ya da Castle DynamicProxy gibi araçlar kullanılabilir.
</p>
