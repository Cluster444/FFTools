// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FFTools.Data
{

using global::System;
using global::FlatBuffers;

public struct StaticData : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static StaticData GetRootAsStaticData(ByteBuffer _bb) { return GetRootAsStaticData(_bb, new StaticData()); }
  public static StaticData GetRootAsStaticData(ByteBuffer _bb, StaticData obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool StaticDataBufferHasIdentifier(ByteBuffer _bb) { return Table.__has_identifier(_bb, "FF1D"); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public StaticData __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Monster? Monsters(int j) { int o = __p.__offset(4); return o != 0 ? (Monster?)(new Monster()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int MonstersLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }
  public Monster? MonstersByKey(string key) { int o = __p.__offset(4); return o != 0 ? Monster.__lookup_by_key(__p.__vector(o), key, __p.bb) : null; }

  public static Offset<StaticData> CreateStaticData(FlatBufferBuilder builder,
      VectorOffset monstersOffset = default(VectorOffset)) {
    builder.StartObject(1);
    StaticData.AddMonsters(builder, monstersOffset);
    return StaticData.EndStaticData(builder);
  }

  public static void StartStaticData(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddMonsters(FlatBufferBuilder builder, VectorOffset monstersOffset) { builder.AddOffset(0, monstersOffset.Value, 0); }
  public static VectorOffset CreateMonstersVector(FlatBufferBuilder builder, Offset<Monster>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartMonstersVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<StaticData> EndStaticData(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<StaticData>(o);
  }
  public static void FinishStaticDataBuffer(FlatBufferBuilder builder, Offset<StaticData> offset) { builder.Finish(offset.Value, "FF1D"); }
};


}
