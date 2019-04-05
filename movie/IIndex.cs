public interface IIndex<K, V>
{
    void Insert(K key, V Value);

    Tuple<K, V> Get(K key);

    IEnumerable<Tuple<K, V>> LargerThanorEqualTo(K key);

    IEnumberable<Tuple<K, V>> LargerThan(K key);

    IEnumerable<Tuple<K, V>> LessThanOrEqualTo(K key);

    IEnumerable<Tuple<K, V>> LessThan(K key);

    bool Delete(K key, V value, IComparer<V> valueComparer = null);

    bool Delete(K key);

}