//List<T> koleksiyonu
//C# dilinde en cok tercih edilen koleksiyon yapısıdır.
//Generic T parametresi koleksiyonun türünü belirten tür olarak ifade edecektir.
//Dizilerden farklı olarak boyutu otomatik olarak ayarlanabilmekte ve içerisine dinamik bir şekilde öğe ekleyip ve çıkarılabilmektedir.


//Dictionary<TKey,TValue>
//Dictionary koleksiyonu key-value formatında kümülatif veri saklayan bir koleksiyondur.
//Key(anahtar) değerleri benzersizdir.


//Queue<T>
//C# dilinde, ilk giren ilk çıkar(FIFO-First In First Out) mantığında çalışan koleksıyondur.
//Bu koleksiyon, elemanların eklenme sırasına göre işlenmesini sağlamaktadır.
//Queue, mantıken bir kuyruk davranışı sergiler.
//Queue koleksiyonu, genellikle iş parçacığı kuyruklarında, işlemlerin sırasına göre işlenmesi gereken senaryolarda ve verilerin sırasıyla işlendiği diğer durumlarda oldukça kullanışlıdır.
//İlk giren ilk çıkar mantığına dayalı olarak çalıştığı için, bu tür senaryolarda verilerin doğru sıra ile işlenmesini sağlar.


//Stack<T>
//C# dilinde, son giren ilk çıkar(LIFO-Last In First Out) mantığında çalışan koleksiyondur.
//Bu koleksiyon tıpkı Queue koleksiyonunda oldugu gibi elemanların eklenme sırasına gore işlenmesini sağlamaktadır.
//Ve yine Queue'de oldugu gibi Stack'de, mantıken bir kuyruk davranışı sergilemektedir.


//LinkedList<T>
//Verileri birbirlerine bağlı düğümler(node) şeklinde saklamaya olanak tanıyan bir koleksiyondur.
//Her düğüm, içereceği veriyi ve bir sonraki düğümün referansını içermektedir.


//SortedList<TKey, TValue>
//SortedList<T> koleksiyonu da key-value tarzında veri tutan bir koleksiyondur. Key'ler sıralı bir şekilde tutulmakta ve bu sayede key'lere göre hızlı erişim durumu söz konusu olmaktadır.
//SortedList koleksiyonunda key'ler tekildir.
//Ayrıca SortedList koleksiyonunda önemli bir noktada key'leri sıralamak için bir karşılaştırma işlemine ihtiyaç duyulmasıdır.
//Eğer koleksiyona eklenen key'lerin sıralanmasını istiyorsanız, bu key'lerin türüne uygun bir karşılaştırıcı belirlemelisiniz.
//Ya da key'e verilen türün default olarak IComparable<T> interface'ini uygulaması da beklenebilir.


//SortedDictionary<TKey, TValue>
//SortedList<T> koleksiyonu da olduğu gibi key-value tarzında veri tutan bir koleksiyondur.
//SortedList'ten en önemli farkı key'leri sıralamak için bir karşılaştırma işlemine ihtiyaç duymamasıdır.
//Bu nedenle key'ler herhangi bir türe uygun olarak eklenip direkt sıralanabilir.
//SortedDictionary koleksiyonu, key'lerin sıralı bir şekilde tutulması istendiğinde özel bir key sıralaması gerekmediği durumlarda kullanılabilir.


//ObservableCollection<T>
//Verilerin eklendiği,çıkarıldıgı veya değiştirildiği durumlarda otomatik olarak izleme yapan bir koleksiyondur.
//Bu koleksiyon ile verilerde yapılan değişiklikleri 'Event Notifications' denen olay bildirimleriyle takip edebilirsiniz.
//Bu notifikasyonlar neticesinde, CollectionChanged event'i tetiklenir.
//Bu event sayesinde koleksiyona bağlı olan bileşenlerin otomatik olarak güncellenmesi sağlanabilir.