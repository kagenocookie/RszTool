using System.Numerics;
using RszTool.Clip;
using RszTool.Common;

namespace RszTool.Clip
{
    public enum ClipVersion
    {
        RE7 = 10,
        RE7_RT = 11,
        RE2_DMC5 = 27,
        RE3 = 34,
        MHR_DEMO = 40,
        RE8 = MHR_DEMO,
        RE2_RT = 43,
        RE3_RT = RE2_RT,
        MHR = 43,
        SF6 = 53,
        RE4 = 54,
    }


    public enum InterpolationType
    {
        Unknown = 0x0,
        Discrete = 0x1,
        Linear = 0x2,
        Event = 0x3,
        Slerp = 0x4,
        Hermite = 0x5,
        AutoHermite = 0x6,
        Bezier = 0x7,
        AutoBezier = 0x8,
        OffsetFrame = 0x9,
        OffsetSec = 0xA,
        PassEvent = 0xB,
        Bezier3D = 0xC,
        Range = 0xD,
        DiscreteToEnd = 0xE,
    }


    public enum PropertyType : byte
    {
        Unknown = 0x0,
        Bool = 0x1,
        S8 = 0x2,
        U8 = 0x3,
        S16 = 0x4,
        U16 = 0x5,
        S32 = 0x6,
        U32 = 0x7,
        S64 = 0x8,
        U64 = 0x9,
        F32 = 0xA,
        F64 = 0xB,
        Str8 = 0xC,
        Str16 = 0xD,
        Enum = 0xE,
        Quaternion = 0xF,
        Array = 0x10,
        NativeArray = 0x11,
        Class = 0x12,
        NativeClass = 0x13,
        Struct = 0x14,
        Vec2 = 0x15,
        Vec3 = 0x16,
        Vec4 = 0x17,
        Color = 0x18,
        Range = 0x19,
        Float2 = 0x1A,
        Float3 = 0x1B,
        Float4 = 0x1C,
        RangeI = 0x1D,
        Point = 0x1E,
        Size = 0x1F,
        Asset = 0x20,
        Action = 0x21,
        Guid = 0x22,
        Uint2 = 0x23,
        Uint3 = 0x24,
        Uint4 = 0x25,
        Int2 = 0x26,
        Int3 = 0x27,
        Int4 = 0x28,
        OBB = 0x29,
        Mat4 = 0x2A,
        Rect = 0x2B,
        PathPoint3D = 0x2C,
        Plane = 0x2D,
        Sphere = 0x2E,
        Capsule = 0x2F,
        AABB = 0x30,
        Nullable = 0x31,
        Sfix = 0x32,
        Sfix2 = 0x33,
        Sfix3 = 0x34,
        Sfix4 = 0x35,
        AnimationCurve = 0x36,
        KeyFrame = 0x37,
        GameObjectRef = 0x38,
    }

    public static class PropertyTypeUtils
    {
        public static RszFieldType ToRszFieldType(PropertyType type)
        {
            return type switch
            {
                PropertyType.Bool => RszFieldType.Bool,
                PropertyType.S8 => RszFieldType.S8,
                PropertyType.U8 => RszFieldType.U8,
                PropertyType.S16 => RszFieldType.S16,
                PropertyType.U16 => RszFieldType.U16,
                PropertyType.S32 => RszFieldType.S32,
                PropertyType.U32 => RszFieldType.U32,
                PropertyType.S64 => RszFieldType.S64,
                PropertyType.U64 => RszFieldType.U64,
                PropertyType.F32 => RszFieldType.F32,
                PropertyType.F64 => RszFieldType.F64,
                PropertyType.Str8 => RszFieldType.String,
                PropertyType.Str16 => RszFieldType.String,
                PropertyType.Enum => RszFieldType.Enum,
                PropertyType.Quaternion => RszFieldType.Quaternion,
                PropertyType.Array => RszFieldType.ukn_type,
                PropertyType.NativeArray => RszFieldType.ukn_type,
                PropertyType.Class => RszFieldType.ukn_type,
                PropertyType.NativeClass => RszFieldType.ukn_type,
                PropertyType.Struct => RszFieldType.Struct,
                PropertyType.Vec2 => RszFieldType.Vec2,
                PropertyType.Vec3 => RszFieldType.Vec3,
                PropertyType.Vec4 => RszFieldType.Vec4,
                PropertyType.Color => RszFieldType.Color,
                PropertyType.Range => RszFieldType.Range,
                PropertyType.Float2 => RszFieldType.Float2,
                PropertyType.Float3 => RszFieldType.Float3,
                PropertyType.Float4 => RszFieldType.Float4,
                PropertyType.RangeI => RszFieldType.RangeI,
                PropertyType.Point => RszFieldType.Point,
                PropertyType.Size => RszFieldType.Size,
                PropertyType.Asset => RszFieldType.ukn_type,
                PropertyType.Action => RszFieldType.Action,
                PropertyType.Guid => RszFieldType.Guid,
                PropertyType.Uint2 => RszFieldType.Uint2,
                PropertyType.Uint3 => RszFieldType.Uint3,
                PropertyType.Uint4 => RszFieldType.Uint4,
                PropertyType.Int2 => RszFieldType.Int2,
                PropertyType.Int3 => RszFieldType.Int3,
                PropertyType.Int4 => RszFieldType.Int4,
                PropertyType.OBB => RszFieldType.OBB,
                PropertyType.Mat4 => RszFieldType.Mat4,
                PropertyType.Rect => RszFieldType.Rect,
                PropertyType.PathPoint3D => RszFieldType.ukn_type,
                PropertyType.Plane => RszFieldType.Plane,
                PropertyType.Sphere => RszFieldType.Sphere,
                PropertyType.Capsule => RszFieldType.Capsule,
                PropertyType.AABB => RszFieldType.AABB,
                PropertyType.Nullable => RszFieldType.ukn_type,
                PropertyType.Sfix => RszFieldType.Sfix,
                PropertyType.Sfix2 => RszFieldType.Sfix2,
                PropertyType.Sfix3 => RszFieldType.Sfix3,
                PropertyType.Sfix4 => RszFieldType.Sfix4,
                PropertyType.AnimationCurve => RszFieldType.ukn_type,
                PropertyType.KeyFrame => RszFieldType.KeyFrame,
                PropertyType.GameObjectRef => RszFieldType.GameObjectRef,
                _ => RszFieldType.ukn_type,
            };
        }
    }


    public class Key : BaseModel
    {
        public float frame;
        public float rate;
        public InterpolationType interpolation;
        public bool instanceValue;
        public ushort reserved;
        public uint reserved2;
        public object Value { get; set; } = null!;

        public PropertyType PropertyType { get; set; }
        public WeakReference<ClipEntry> ClipFile { get; set; }

        public Key(ClipEntry clipFile)
        {
            ClipFile = new(clipFile);
        }

        protected override bool DoRead(FileHandler handler)
        {
            handler.Read(ref frame);
            handler.Read(ref rate);
            handler.Read(ref interpolation);
            handler.Read(ref instanceValue);
            handler.Read(ref reserved);
            handler.Read(ref reserved2);
            handler.Seek(Start + ClipFile.GetTarget()!.KeySize);
            return true;
        }

        public void ReadValue(FileHandler handler, Property property)
        {
            handler.Seek(Start + 16);
            var clipFile = ClipFile.GetTarget()!;
            PropertyType = property.Info.DataType;
            // Value
            if (PropertyType == PropertyType.Unknown)
            {
                Value = handler.Read<uint>();
            }
            else switch (PropertyType)
            {
                case PropertyType.Bool:
                    Value = handler.Read<bool>();
                    break;
                case PropertyType.S8:
                    Value = handler.Read<sbyte>();
                    break;
                case PropertyType.U8:
                    Value = handler.Read<byte>();
                    break;
                case PropertyType.S16:
                    Value = handler.Read<short>();
                    break;
                case PropertyType.U16:
                    Value = handler.Read<ushort>();
                    break;
                case PropertyType.S32:
                    Value = handler.Read<int>();
                    break;
                case PropertyType.U32:
                    Value = handler.Read<uint>();
                    break;
                case PropertyType.S64:
                    Value = handler.Read<long>();
                    break;
                case PropertyType.U64:
                    Value = handler.Read<ulong>();
                    break;
                case PropertyType.F32:
                    Value = handler.Read<float>();
                    break;
                case PropertyType.F64:
                    Value = handler.Read<double>();
                    break;
                case PropertyType.Str8:
                case PropertyType.Enum:
                    {
                        long offset = handler.Read<long>();
                        if (clipFile.Header.namesOffsetExtra == null)
                        {
                            throw new Exception("namesOffsetExtra is null");
                        }
                        Value = handler.ReadAsciiString(clipFile.Header.namesOffsetExtra[1] + offset);
                    }
                    break;
                case PropertyType.Str16:
                case PropertyType.Asset:
                case PropertyType.Guid:
                    {
                        long offset = handler.Read<long>();
                        if (clipFile.Header.namesOffsetExtra == null)
                        {
                            throw new Exception("namesOffsetExtra is null");
                        }
                        // clipHeader.unicodeNamesOffs + start + offset*2
                        Value = handler.ReadWString(clipFile.Header.unicodeNamesOffset + offset);
                    }
                    break;
                default:
                    throw new Exception($"Unsupported PropertyType: {PropertyType}");
            }
        }

        protected override bool DoWrite(FileHandler handler)
        {
            handler.Write(frame);
            handler.Write(rate);
            handler.Write(interpolation);
            handler.Write(instanceValue);
            handler.Write(reserved);
            handler.Write(reserved2);
            // Value
            return true;
        }
    }


    public class PropertyInfo : BaseModel
    {
        public ClipVersion Version { get; set; }

        private uint pad;
        private int uknRE7_1;
        public float startFrame;  // Start
        public float endFrame;  // End
        private uint U32_1;
        private ulong U64_1;

        public long nameOffset;
        public long dataOffset;
        public long ChildStartIndex;
        public ushort ChildMembershipCount;
        public short arrayIndex;
        public short speedPointNum;
        public PropertyType DataType;
        public byte uknByte00;
        public byte uknByte;
        public long lastKeyOffset;
        public long speedPointOffset;
        public long clipPropertyOffset;

        public byte uknCount;
        public ulong RE3hash;
        public ulong uknRE7_2;
        public ulong uknRE7_3;
        public ulong uknRE7_4;
        public long nameOffset2;


        public PropertyInfo(ClipVersion version)
        {
            Version = version;
        }

        protected override bool DoRead(FileHandler handler)
        {
            if (Version < ClipVersion.RE8) handler.Read(ref pad);
            if (Version == ClipVersion.RE7) handler.Read(ref uknRE7_1);
            handler.Read(ref startFrame);
            handler.Read(ref endFrame);
            if (Version == ClipVersion.RE7)
                handler.Read(ref U32_1);
            else
                handler.Read(ref U64_1);
            if (Version >= ClipVersion.RE8)
            {
                handler.Read(ref nameOffset);
                handler.Read(ref dataOffset);
                handler.Read(ref ChildStartIndex);
                handler.Read(ref ChildMembershipCount);
                handler.Read(ref arrayIndex);
                if (Version > ClipVersion.RE8)
                    speedPointNum = handler.ReadByte();
                else
                    handler.Read(ref speedPointNum);
                handler.Read(ref DataType);
                if (Version > ClipVersion.RE8)
                    handler.Read(ref uknByte00);
                handler.Read(ref uknByte);
                handler.Read(ref lastKeyOffset);
                if (Version != ClipVersion.RE4)
                {
                    handler.Read(ref speedPointOffset);
                    handler.Read(ref clipPropertyOffset);
                }
            }
            else
            {
                handler.Read(ref DataType);
                handler.Read(ref uknCount);
                handler.Skip(2);
                if (Version == ClipVersion.RE3)
                    handler.Read(ref RE3hash);
                else
                    handler.Skip(8);
                if (Version == ClipVersion.RE7)
                {
                    handler.Skip(8);
                    handler.Read(ref uknRE7_2);
                }
                handler.Read(ref nameOffset);
                handler.Read(ref nameOffset2);  // why?
                if (Version == ClipVersion.RE7)
                {
                    handler.Read(ref uknRE7_3);
                    handler.Skip(8);
                }
                handler.Skip(8);
                if (Version == ClipVersion.RE7)
                {
                    handler.Skip(16);
                }
                handler.Read(ref ChildStartIndex);
                handler.Read(ref ChildMembershipCount);
                if (Version == ClipVersion.RE7)
                {
                    handler.Skip(8);
                    handler.Read(ref uknRE7_4);
                }
            }
            return true;
        }

        protected override bool DoWrite(FileHandler handler)
        {
            throw new NotImplementedException();
        }
    }


    public class Property
    {
        public PropertyInfo Info { get; }
        public List<Property>? ChildProperties { get; set; }
        public List<Key>? Keys { get; set; }
        public string FunctionName { get; set; } = string.Empty;

        public Property(ClipVersion version)
        {
            Info = new(version);
        }

        public bool IsProertyContainer
        {
            get
            {
                switch (Info.DataType)
                {
                    case PropertyType.Quaternion:  // 0x0F
                    case PropertyType.Array:       // 0x10
                    case PropertyType.NativeArray: // 0x11
                    case PropertyType.Class:       // 0x12
                    case PropertyType.NativeClass: // 0x13
                    case PropertyType.Struct:      // 0x14
                    case PropertyType.Vec2:        // 0x15
                    case PropertyType.Vec3:        // 0x16
                    case PropertyType.Vec4:        // 0x17
                    case PropertyType.Color:       // 0x18
                    case PropertyType.Range:       // 0x19
                    case PropertyType.Float2:      // 0x1A
                    case PropertyType.Float3:      // 0x1B
                    case PropertyType.Float4:      // 0x1C
                    case PropertyType.RangeI:      // 0x1D
                    case PropertyType.Point:       // 0x1E
                    case PropertyType.OBB:         // 0x29
                    case PropertyType.Mat4:        // 0x2A
                    case PropertyType.Nullable:    // 0x31
                        return true;
                    default:
                        return false;
                }
            }
        }
    }


    public class CTRACKS : BaseModel
    {
        public int nodeCount;
        public int propCount;
        public float Start_Frame;
        public float End_Frame;
        public Guid guid1;
        public Guid guid2;

        public byte nodeType;

        public ulong hash;
        public long nameOffset;
        public long nameOffset2;
        public long firstPropIdx;

        public ClipVersion Version { get; set; }

        public CTRACKS(ClipVersion version)
        {
            Version = version;
        }

        protected override bool DoRead(FileHandler handler)
        {
            if (Version >= ClipVersion.RE8)
            {
                nodeCount = handler.ReadShort();
                propCount = handler.ReadShort();
                handler.Read(ref nodeType);
                handler.Skip(3);
            }
            else
            {
                handler.Read(ref nodeCount);
                handler.Read(ref propCount);
                handler.Read(ref Start_Frame);
                handler.Read(ref End_Frame);
                handler.Read(ref guid1);
                handler.Read(ref guid2);
                handler.Skip(8);
            }
            handler.Read(ref hash);
            handler.Read(ref nameOffset);
            handler.Read(ref nameOffset2);
            handler.Read(ref firstPropIdx);
            if (Version == ClipVersion.RE2_DMC5)
            {
                handler.Read(ref firstPropIdx);  // need check
            }
            return true;
        }

        protected override bool DoWrite(FileHandler handler)
        {
            throw new NotImplementedException();
        }
    }


    /// <summary>
    /// 这是Embedded Clip的结构，用在motlists和gui文件中，单独的clip结构不一样，多几个字段
    /// 暂时没想好怎么做兼容
    /// </summary>
    public class ClipHeader : BaseModel
    {
        public uint magic;
        public ClipVersion version;
        public float NumFrames;
        public int numNodes;
        public int numProperties;
        public int numKeys;

        public Guid guid;
        public long clipDataOffset;
        public long propertiesOffset;
        public long keysOffset;
        public long namesOffset;

        public long namesOffset2;

        public long[]? namesOffsetExtra;

        public long unicodeNamesOffset;
        public long endClipStructsOffset1;
        public long endClipStructsOffset2;

        protected override bool DoRead(FileHandler handler)
        {
            handler.Read(ref magic);
            handler.Read(ref version);
            handler.Read(ref NumFrames);
            handler.Read(ref numNodes);
            handler.Read(ref numProperties);
            handler.Read(ref numKeys);
            if (version != ClipVersion.RE3 && version < ClipVersion.RE8)
            {
                handler.Read(ref guid);
            }
            handler.Read(ref clipDataOffset);
            handler.Read(ref propertiesOffset);
            handler.Read(ref keysOffset);
            handler.Read(ref namesOffset);
            if (version == ClipVersion.RE2_DMC5)
            {
                handler.Read(ref namesOffset2);
            }
            namesOffsetExtra = version switch
            {
                ClipVersion.RE7 => handler.ReadArray<long>(5),
                ClipVersion.RE4 or ClipVersion.SF6 => handler.ReadArray<long>(3),
                _ => handler.ReadArray<long>(4),
            };
            handler.Read(ref unicodeNamesOffset);
            handler.Read(ref endClipStructsOffset1);
            if (version <= ClipVersion.RE4)
            {
                handler.Read(ref endClipStructsOffset2);
            }
            return true;
        }

        protected override bool DoWrite(FileHandler handler)
        {
            throw new NotImplementedException();
        }
    }


    public struct EndClipStruct
    {
        public int ukn;
        public uint ukn1;
        public ulong ukn2;
    }


    public class ClipEntry : BaseModel
    {
        public ClipHeader Header { get; } = new();
        public long endClipOffset;
        public long lastUnicodeNameOffset;
        public List<CTRACKS> CTracksList { get; } = new();
        public List<Property> Properties { get; } = new();
        public List<Key> ClipKeys { get; } = new();
        public float[]? Unknown_Floats { get; set; }
        public List<string> Names { get; } = new();
        public List<string> UnicodeNames { get; } = new();
        public EndClipStruct[]? EndClipStructs { get; set; }

        public const uint Magic = 0x50494C43;
        public const string Extension = ".clip";

        public ClipVersion Version => Header.version;

        public int PropertySize => Version switch
        {
            ClipVersion.RE3 => 32,
            ClipVersion.RE7 => 120,
            ClipVersion.MHR_DEMO or ClipVersion.RE8 => 72,
            ClipVersion.SF6 or ClipVersion.RE4 => 56,
            _ => 112,
        };

        public int KeySize => Version switch
        {
            ClipVersion.RE3 or
            ClipVersion.MHR_DEMO or ClipVersion.RE8 or
            ClipVersion.SF6 or ClipVersion.RE4 => 32,
            _ => 40,
        };

        protected override bool DoRead(FileHandler handler)
        {
            CTracksList.Clear();
            Properties.Clear();
            ClipKeys.Clear();
            Names.Clear();
            UnicodeNames.Clear();
            // TODO check isEndOfClip
            var clipHeader = Header;
            if (!clipHeader.Read(handler)) return false;
            if (clipHeader.magic != Magic)
            {
                throw new InvalidDataException($"{handler.FilePath} Not a CLIP file");
            }
            if (clipHeader.numNodes > 0)
            {
                handler.Seek(clipHeader.clipDataOffset);
                for (int i = 0; i < clipHeader.numNodes; i++)
                {
                    CTRACKS cTrack = new(Version);
                    cTrack.Read(handler);
                    CTracksList.Add(cTrack);
                }
            }

            if (clipHeader.numProperties > 0)
            {
                handler.Seek(clipHeader.propertiesOffset);
                for (int i = 0; i < clipHeader.numProperties; i++)
                {
                    Property property = new(Version);
                    property.Info.Read(handler);
                    if (clipHeader.namesOffsetExtra != null && clipHeader.namesOffsetExtra.Length > 1)
                    {
                        property.FunctionName = handler.ReadAsciiString(clipHeader.namesOffsetExtra[1] + property.Info.nameOffset);
                    }
                    Properties.Add(property);
                }
            }

            if (clipHeader.numKeys > 0)
            {
                handler.Seek(clipHeader.keysOffset);
                for (int i = 0; i < clipHeader.numKeys; i++)
                {
                    Key key = new(this);
                    key.Read(handler);
                    ClipKeys.Add(key);
                }
            }

            // sub properties or sub keys
            foreach (var property in Properties)
            {
                if (property.Info.ChildMembershipCount == 0) continue;
                if (property.IsProertyContainer)
                {
                    property.ChildProperties ??= new();
                    for (long i = property.Info.ChildStartIndex; i < property.Info.ChildMembershipCount; i++)
                    {
                        property.ChildProperties.Add(Properties[(int)i]);
                    }
                }
                else
                {
                    property.Keys ??= new();
                    for (long i = property.Info.ChildStartIndex; i < property.Info.ChildMembershipCount; i++)
                    {
                        Key key = ClipKeys[(int)i];
                        property.Keys.Add(key);
                        key.ReadValue(handler, property);
                    }
                }
            }

            if (clipHeader.namesOffsetExtra != null)
            {
                if (clipHeader.namesOffsetExtra[1] - clipHeader.namesOffset > 0)
                {
                    handler.Seek(clipHeader.namesOffset);
                    Unknown_Floats = handler.ReadArray<float>((int)(clipHeader.namesOffsetExtra[1] - clipHeader.namesOffset) / 4);
                }

                /* handler.Seek(clipHeader.namesOffsetExtra[1]);
                for (int i = 0; i < clipHeader.numProperties + clipHeader.numNodes; i++)
                {

                } */
            }

            if (Version != ClipVersion.RE7 && clipHeader.numNodes > 1)
            {
                handler.Seek(clipHeader.endClipStructsOffset1);
                {
                    EndClipStructs = handler.ReadArray<EndClipStruct>(clipHeader.numNodes - 1);
                }
            }

            return true;
        }

        protected override bool DoWrite(FileHandler handler)
        {
            throw new NotImplementedException();
        }
    }
}


namespace RszTool
{
    public class ClipFile(RszFileOption option, FileHandler fileHandler) : BaseRszFile(option, fileHandler)
    {
        public ClipEntry ClipEntry { get; } = new();

        protected override bool DoRead()
        {
            var handler = FileHandler;
            return ClipEntry.Read(handler);
        }

        protected override bool DoWrite()
        {
            throw new NotImplementedException();
        }
    }
}
