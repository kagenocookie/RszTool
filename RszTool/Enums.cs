namespace RszTool
{
    public enum RszFieldType : uint
    {
        ukn_error = 0,
        ukn_type,
        not_init,
        class_not_found,
        out_of_range,
        Undefined,
        Object,
        Action,
        Struct,
        NativeObject,
        Resource,
        UserData,
        Bool,
        C8,
        C16,
        S8,
        U8,
        UByte = U8,
        S16,
        U16,
        S32,
        U32,
        S64,
        U64,
        F32,
        F64,
        String,
        MBString,
        Enum,
        Uint2,
        Uint3,
        Uint4,
        Int2,
        Int3,
        Int4,
        Float2,
        Float3,
        Float4,
        Float3x3,
        Float3x4,
        Float4x3,
        Float4x4,
        Half2,
        Half4,
        Mat3,
        Mat4,
        Vec2,
        Vec3,
        Vec4,
        VecU4,
        Quaternion,
        Guid,
        Color,
        DateTime,
        AABB,
        Capsule,
        TaperedCapsule,
        Cone,
        Line,
        LineSegment,
        OBB,
        Plane,
        PlaneXZ,
        Point,
        Range,
        RangeI,
        Ray,
        RayY,
        Segment,
        Size,
        Sphere,
        Triangle,
        Cylinder,
        Ellipsoid,
        Area,
        Torus,
        Rect,
        Rect3D,
        Frustum,
        KeyFrame,
        Uri,
        GameObjectRef,
        RuntimeType,
        Sfix,
        Sfix2,
        Sfix3,
        Sfix4,
        Position,
        F16,
        End,
        Data
    };

    enum MAGIC {
        id_SCN = 5129043,
        id_PFB = 4343376,
        id_USR = 5395285,
        id_RCOL = 1280262994,
        id_mfs2 = 846423661,
        id_BHVT = 1414940738,
        id_uvar = 1918989941,
        id_fchr = 1919443814,
    }


    public enum FileType
    {
        unknown,
        user,
        scn,
        pfb,
        mdf2,
        gui,
    }


    public enum GameName
    {
        unknown,
        re2,
        re2rt,
        re3,
        re3rt,
        re4,
        re8,
        re7,
        re7rt,
        dmc5,
        mhrise,
        sf6,
        dd2,
        gtrick,
        apollo,
        drdr,
        mhwilds,
    }


    public enum GameVersion
    {
        unknown,
        re7 = 1,
        re2 = 2,
        dmc5 = re2,
        re3 = 3,
        re8 = 4,
        mhrise = 5,
        re2rt = 6,
        re3rt = re2rt,
        re7rt = re2rt,
        re4 = 7,
        dd2 = re4,
        rszmhwilds = re4,
        sf6 = 8,
        gtrick,
        apollo,
        drdr,
    }


    public static class RszDefines
    {
        public static GameName[] GameNames { get; } = (GameName[])Enum.GetValues(typeof(GameName));
    }
}
