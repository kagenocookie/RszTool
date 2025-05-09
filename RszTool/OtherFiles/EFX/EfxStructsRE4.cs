using System.Numerics;
using RszTool;

namespace RszTool.Efx.Structs.RE4;

public enum ExpressionOperator
{
	Addition = 0,
	Subtraction = 1,
	Multiplication = 2,
	Division = 3,
	Assign = 4,
	ForceWord = -1
}

public enum DistortionType
{
	Blur = 0,
	Refract = 1,
	BlurTexture = 2
}

public enum BlendType
{
    AlphaBlend = 0,
    Physical = 1,
    AddContrast = 2,
    EdgeBlend = 3,
    Multiply = 4,
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.FixRandomGenerator, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeFixRandomGenerator : EFXAttribute
{
	public EFXAttributeFixRandomGenerator() : base(EfxAttributeType.FixRandomGenerator) { }

	public uint unkn1_0;
	public int unkn1_1;
	public int unkn1_2;
	public int unkn1_3;
	public int unkn1_4;
	[RszConditional(nameof(Version), ">", EfxVersion.DMC5, EndAt = nameof(unkn1_9))]
	public int unkn1_5;
	public int unkn1_6;
	public int unkn1_7;
	public int unkn1_8;
	public int unkn1_9;
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.EffectOptimizeShader, EfxVersion.RE4)]
public partial class EFXAttributeEffectOptimizeShader : EFXAttribute
{
	public EFXAttributeEffectOptimizeShader() : base(EfxAttributeType.EffectOptimizeShader) { }

	public uint unknShaderCRCHash0;
	public uint unknShaderCRCHash1;
	public uint unknShaderCRCHash2;
	[RszInlineWString] public string? shaderPath;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.Transform2D, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeTransform2D : EFXAttribute
{
	public Vector2 position;
	public int rotation;
	public Vector2 scale;

	public EFXAttributeTransform2D() : base(EfxAttributeType.Transform2D) { }
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.Transform2DModifierDelayFrame, EfxVersion.RE4)]
public partial class EFXAttributeTransform2DModifierDelayFrame : EFXAttribute
{
	public EFXAttributeTransform2DModifierDelayFrame() : base(EfxAttributeType.Transform2DModifierDelayFrame) { }

	public uint frameDelay;
	public uint unkn1;

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.Transform2DExpression, EfxVersion.RERT, EfxVersion.RE4)]
public partial class EFXAttributeTransform2DExpression : EFXAttribute
{
	public EFXAttributeTransform2DExpression() : base(EfxAttributeType.Transform2DExpression) { }

	public uint unkn1_0;
	public uint unkn1_1;
	[RszConditional(nameof(Version), ">", EfxVersion.DMC5, EndAt = nameof(unkn1_5))]
	public uint unkn1_2;
	public uint unkn1_3;
	public uint unkn1_4;
	public uint unkn1_5;
	[RszClassInstance]
	public EFXExpressionListWrapper expressions = new();
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.Transform3D, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeTransform3D : EFXAttribute
{
	public EFXAttributeTransform3D() : base(EfxAttributeType.Transform3D) { }

	public Vector3 translation;
	public Vector3 rotation;
	public Vector3 scale;
	public int rotationOrder;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.Transform3DModifierDelayFrame, EfxVersion.RE4)]
public partial class EFXAttributeTransform3DModifierDelayFrame : EFXAttribute
{
	public EFXAttributeTransform3DModifierDelayFrame() : base(EfxAttributeType.Transform3DModifierDelayFrame) { }

	public uint frameDelay;
	public uint null1;

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.Transform3DModifier, EfxVersion.RE4)]
public partial class EFXAttributeTransform3DModifier : EFXAttribute
{
	public EFXAttributeTransform3DModifier() : base(EfxAttributeType.Transform3DModifier) { }

	public uint unkn1_0;
	public uint null1_1;
	public float unkn1_2;
	public float unkn1_3;
	public float unkn1_4;
	public float unkn1_5;
	public float unkn1_6;
	public float unkn1_7;
	public float unkn1_8;
	public float unkn1_9;
	public float unkn1_10;
	public float unkn1_11;
	public float unkn1_12;
	public float unkn1_13;
	public float unkn1_14;
	public float unkn1_15;
	public float unkn1_16;
	public float unkn1_17;
	public float unkn1_18;
	public float unkn1_19;
	public uint null1_20;
	public float unkn1_21;
	public uint null1_22;
	public uint unkn1_23;
	public uint unkn1_24;
	public float unkn1_25;
	public uint null1_26;
	public float unkn1_27;
	public uint unkn1_28;
	public float unkn1_29;
	public uint unkn1_30;
	public float unkn1_31;
	public float unkn1_32;
	public float unkn1_33;
	public float unkn1_34;
	public float unkn1_35;
	public float unkn1_36;
	public float unkn1_37;
	public float unkn1_38;
	public float unkn1_39;
	public float unkn1_40;
	public float unkn1_41;
	public float unkn1_42;
	public float unkn1_43;
	public uint unkn1_44;
	public float unkn1_45;
	public uint null1_46;
	public float unkn1_47;
	public uint unkn1_48;
	public float unkn1_49;
	public uint null1_50;
	public float unkn1_51;
	public uint unkn1_52;
	public float unkn1_53;
	public uint null1_54;
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.Transform3DExpression, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeTransform3DExpression : EFXAttribute
{
	public EFXAttributeTransform3DExpression() : base(EfxAttributeType.Transform3DExpression) { }

	public uint unkn1;
	public uint unkn2;
	public uint unkn3;
	public uint unkn4;
	public uint unkn5;
	public uint unkn6;
	public uint unkn7;
	public uint unkn8;
	public uint unkn9;
	public uint unkn10;
	[RszClassInstance] public EFXExpressionListWrapper expressions = new();
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.ParentOptions, EfxVersion.RERT, EfxVersion.RE4)]
public partial class EFXAttributeParentOptions : EFXAttribute, IBoneRelationAttribute
{
	public via.Int3 RelationPos;
	public via.Int3 RelationRot;
	public via.Int3 RelationScl;
	public byte ParticleUseLocal;
	public float ConstInheritRate;
	public float ConstInheritVariation;
	public uint ConstFrame;
	public uint ConstFrameVariation;
	public uint unkn6;
	public uint unkn7;
	public float unkn8;
	[RszInlineWString] public string? boneName;

	public EFXAttributeParentOptions() : base(EfxAttributeType.ParentOptions) { }

    public string? ParentBone { get; set; }
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.Spawn, EfxVersion.RERT, EfxVersion.RE4)]
public partial class EFXAttributeSpawn : EFXAttribute
{
	public uint maxParticles;
	public uint rawMaxParticles;
	public via.Int2 spawnNum;
	public via.Int2 intervalFrame;
	public uint useSpawnFrame;
	public via.RangeI spawnFrame;

	[RszConditional(nameof(Version), ">", EfxVersion.DMC5, EndAt = nameof(re4_unkn6))]
	public via.RangeI loopNum;

	public via.Int2 emitterdelayFrame;

	public uint ringBufferMode;

	[RszConditional(nameof(Version), ">=", EfxVersion.RERT, EndAt = nameof(re4_unkn6))]
	public uint sb_unkn3;

	[RszConditional(nameof(Version), ">=", EfxVersion.RE4, EndAt = nameof(re4_unkn6))]
	public uint re4_unkn0;
	public float re4_unkn1;
	public uint re4_unkn2;
	public float re4_unkn3;
	public float re4_unkn4;
	public float re4_unkn5;
	public float re4_unkn6;

	public EFXAttributeSpawn() : base(EfxAttributeType.Spawn) { }
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypeBillboard2D, EfxVersion.RE4)]
public partial class EFXAttributeTypeBillboard2D : EFXAttribute
{
	public uint unkn1;
	public via.Color color0;
	public via.Color color1;
	public float unkn2_0;
	public uint null2_1;
	public uint null2_2;
	public float unkn2_3;
	public float unkn2_4;
	public float unkn2_5;
	public float unkn2_6;
	public float unkn2_7;
	public uint null2_8;
	public float unkn2_9;
	public uint null2_10;
	public float unkn2_11;
	public uint null2_12;

	public EFXAttributeTypeBillboard2D() : base(EfxAttributeType.TypeBillboard2D) { }
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.Life, EfxVersion.RE4)]
public partial class EFXAttributeLife : EFXAttribute
{
	public uint AppearFrameMin;
	public uint AppearFrameMax;
	public uint KeepFrameMin;
	public uint KeepFrameMax;
	public uint VanishFrameMin;
	public uint VanishFrameMax;
	public uint unkn7; // Might be KeepHoldFrame
	public uint unkn8; // Might be KeepHoldFrameVariation
	public uint unkn9;

	public EFXAttributeLife() : base(EfxAttributeType.Life) { }
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypeNoDraw, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeTypeNoDraw : EFXAttribute
{
	public uint unkn1_0;
	public via.Color color0;
	public via.Color color1;
	public float unkn1_3;

	public uint unkn1_4;
	public uint null1_5;
	public uint null1_6;
	public float unkn1_7;
	public uint unkn1_8;
	public uint null1_9;
	public float unkn1_10;
	public uint null1_11;
	public float unkn1_12;
	public uint null1_13;
	public float unkn1_14;
	public uint null1_15;

	public EFXAttributeTypeNoDraw() : base(EfxAttributeType.TypeNoDraw) { }
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.EmitterShape3D, EfxVersion.RERT, EfxVersion.RE4)]
public partial class EFXAttributeEmitterShape3D : EFXAttribute
{
	public EFXAttributeEmitterShape3D() : base(EfxAttributeType.EmitterShape3D) { }

	public float RangeXMin;
	public float RangeXMax;
	public float RangeYMin;
	public float RangeYMax;
	public float RangeZMin;
	public float RangeZMax;
	public uint ShapeType;
	public uint RangeDivideNum;
	public uint RangeDivideAxis;
	[RszConditional(nameof(Version), ">", EfxVersion.DMC5, EndAt = nameof(unkn1_10))]
	public uint emitCount;
	public uint unkn1_10;
	public float LocalRotationX;
	public float LocalRotationY;
	public float LocalRotationZ;
	public uint RotationOrder;
	[RszConditional(nameof(Version), "==", EfxVersion.MHRiseSB, "||", nameof(Version), "==", EfxVersion.RERT)]
	public byte unkn3;
	[RszConditional(nameof(Version), ">=", EfxVersion.RERT, EndAt = nameof(unkn4_3))]
	public uint sb_unkn0;
	[RszConditional(nameof(Version), ">=", EfxVersion.RE4)]
	public uint re4_unkn0;
	public float unkn4_1;
	public float unkn4_2;
	public float unkn4_3;
	public uint unkn4_4;
}



[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.Attractor, EfxVersion.RERT, EfxVersion.RE4)]
public partial class EFXAttributeAttractor : EFXAttribute, IBoneRelationAttribute
{
	public EFXAttributeAttractor() : base(EfxAttributeType.Attractor) { }

	public uint unkn1_0;
	public float unkn1_1;
	public float unkn1_2;
	public float unkn1_3;
	public float attractionForce;
	public float unkn1_5;
	public float unkn1_6;
	public float unkn1_7;
	[RszInlineWString] public string? boneName;

    public string? ParentBone { get; set; }
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.AttractorExpression, EfxVersion.RE4)]
public partial class EFXAttributeAttractorExpression : EFXAttribute
{
	public EFXAttributeAttractorExpression() : base(EfxAttributeType.AttractorExpression) { }

	public uint unkn1_0;
	public uint unkn1_1;
	public uint unkn1_2;
	public uint unkn1_3;
	public uint unkn1_4;
	public uint unkn1_5;
	public uint unkn1_6;
	public uint unkn1_7;
	public uint unkn1_8;
	public uint unkn1_9;
	public uint unkn1_10;
	[RszClassInstance] public EFXExpressionListWrapper expressions = new();
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.Blink, EfxVersion.RE4)]
public partial class EFXAttributeBlink : EFXAttribute
{
	public EFXAttributeBlink() : base(EfxAttributeType.Blink) { }

	public float unkn1_0;
	public float unkn1_1;
	public float unkn1_2;
	public float unkn1_3;
	public float unkn1_4;
	public float unkn1_5;
	public float unkn1_6;
	public float unkn1_7;
	public float unkn1_8;
	public float unkn1_9;

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.ColorGrading, EfxVersion.RE4)]
public partial class EFXAttributeColorGrading : EFXAttribute
{
	public EFXAttributeColorGrading() : base(EfxAttributeType.ColorGrading) { }

	public via.Color color0;//Unconfirmed
	public via.Color color1;//Unconfirmed
	public float unkn1_0;
	public float unkn1_1;
	public float unkn1_2;
	public float unkn1_3;

}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.ContrastHighlighter, EfxVersion.RE4)]
public partial class EFXAttributeContrastHighlighter : EFXAttribute
{
	public EFXAttributeContrastHighlighter() : base(EfxAttributeType.ContrastHighlighter) { }

	public float unkn1_0;
	public float unkn1_1;
	public float unkn1_2;
	public float unkn1_3;
	public uint unkn1_4;
	public float unkn1_5;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.DistortionExpression, EfxVersion.RE4)]
public partial class EFXAttributeDistortionExpression : EFXAttribute
{
	public EFXAttributeDistortionExpression() : base(EfxAttributeType.DistortionExpression) { }

	public uint unkn1_0;
	public uint unkn1_1;
	public uint unkn1_2;
	public uint unkn1_3;
	public uint unkn1_4;
	public uint unkn1_5;
	[RszClassInstance] public EFXExpressionListWrapper expressions = new();
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.DrawOverlay, EfxVersion.DMC5, EfxVersion.RERT, EfxVersion.RE4)]
public partial class EFXAttributeDrawOverlay : EFXAttribute
{
	public EFXAttributeDrawOverlay() : base(EfxAttributeType.DrawOverlay) { }

	public uint unkn0_0;
	public uint unkn0_1;
	public uint unkn0_2;
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.EmitMask, EfxVersion.RE4)]
public partial class EFXAttributeEmitMask : EFXAttribute
{
	public EFXAttributeEmitMask() : base(EfxAttributeType.EmitMask) { }

	public uint unkn1;

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.EmitterColor, EfxVersion.RE4)]
public partial class EFXAttributeEmitterColor : EFXAttribute
{
	public EFXAttributeEmitterColor() : base(EfxAttributeType.EmitterColor) { }

	public uint unkn1;
	public uint unkn2;
	public via.Color color;

}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.EmitterPriority, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeEmitterPriority : EFXAttribute
{
	public EFXAttributeEmitterPriority() : base(EfxAttributeType.EmitterPriority) { }

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.EmitterShape2D, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeEmitterShape2D : EFXAttribute
{
	public EFXAttributeEmitterShape2D() : base(EfxAttributeType.EmitterShape2D) { }

	public float unkn1_0;
	public float unkn1_1;
	public float unkn1_2;
	public float unkn1_3;
	public uint null1_4;
	public uint null1_5;
	public uint null1_6;
	public uint null1_7;

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.EmitterShape2DExpression, EfxVersion.RE4)]
public partial class EFXAttributeEmitterShape2DExpression : EFXAttribute
{
	public EFXAttributeEmitterShape2DExpression() : base(EfxAttributeType.EmitterShape2DExpression) { }

	public uint unkn1_0;
	public uint unkn1_1;
	public uint unkn1_2;
	public uint unkn1_3;
	public uint unkn1_4;
	public uint unkn1_5;
	[RszClassInstance] public EFXExpressionListWrapper expressions = new();

}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.EmitterShape3DExpression, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeEmitterShape3DExpression : EFXAttribute
{
	public EFXAttributeEmitterShape3DExpression() : base(EfxAttributeType.EmitterShape3DExpression) { }

	public uint unkn1_0;
	public uint unkn1_1;
	public uint unkn1_2;
	public uint unkn1_3;
	public uint unkn1_4;
	public uint unkn1_5;
	public uint unkn1_6;
	public uint unkn1_7;
	[RszConditional(nameof(Version), '>', EfxVersion.DMC5, EndAt = nameof(unkn1_9))]
	public uint unkn1_8;
	public uint unkn1_9;
	[RszClassInstance] public EFXExpressionListWrapper expressions = new();
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.FadeByAngle, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeFadeByAngle : EFXAttribute
{
	public EFXAttributeFadeByAngle() : base(EfxAttributeType.FadeByAngle) { }

	public uint unkn1_0;
	public float unkn1_1;
	public float unkn1_2;
	public uint unkn1_3;
	public float unkn1_4;
	public float unkn1_5;
	public float unkn1_6;

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.FadeByAngleExpression, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeFadeByAngleExpression : EFXAttribute
{
	public EFXAttributeFadeByAngleExpression() : base(EfxAttributeType.FadeByAngleExpression) { }

    public uint unkn0;
    public uint unkn1;
    public uint unkn2;
	[RszClassInstance] public EFXExpressionListWrapper expressions = new();
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.FadeByDepth, EfxVersion.DMC5, EfxVersion.RERT, EfxVersion.RE4)]
public partial class EFXAttributeFadeByDepth : EFXAttribute
{
	public EFXAttributeFadeByDepth() : base(EfxAttributeType.FadeByDepth) { }

	public float unkn1; // are these uints in DMC5?
	public float unkn2;
	public float unkn3;
	public float unkn4;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.FadeByDepthExpression, EfxVersion.DMC5, EfxVersion.RERT, EfxVersion.RE4)]
public partial class EFXAttributeFadeByDepthExpression : EFXAttribute
{
	public EFXAttributeFadeByDepthExpression() : base(EfxAttributeType.FadeByDepthExpression) { }

	public uint unkn1_0;
	public uint unkn1_1;
	public uint unkn1_2;
	public uint unkn1_3;
	public uint unkn1_4;
	[RszClassInstance] public EFXExpressionListWrapper expressions = new();
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.FadeByEmitterAngle, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeFadeByEmitterAngle : EFXAttribute
{
	public EFXAttributeFadeByEmitterAngle() : base(EfxAttributeType.FadeByEmitterAngle) { }

	public uint unkn1_0;
	public float unkn1_1;
	public float unkn1_2;
	public float unkn1_3;
	public float unkn1_4;
	public float unkn1_5;

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.FadeByOcclusion, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeFadeByOcclusion : EFXAttribute
{
	public EFXAttributeFadeByOcclusion() : base(EfxAttributeType.FadeByOcclusion) { }

	public float unkn1;
	public uint null2;
	public uint null3;
	public float unkn4;

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.IgnorePlayerColor, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeIgnorePlayerColor : EFXAttribute
{
	public EFXAttributeIgnorePlayerColor() : base(EfxAttributeType.IgnorePlayerColor) { }

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.LifeExpression, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeLifeExpression : EFXAttribute
{
	public EFXAttributeLifeExpression() : base(EfxAttributeType.LifeExpression) { }

	public uint unkn1_0;
	public uint unkn1_1;
	public uint unkn1_2;
	public uint unkn1_3;
	[RszClassInstance] public EFXExpressionListWrapper expressions = new();

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.LuminanceBleed, EfxVersion.RERT, EfxVersion.RE4)]
public partial class EFXAttributeLuminanceBleed : EFXAttribute
{
	public EFXAttributeLuminanceBleed() : base(EfxAttributeType.LuminanceBleed) { }

	public uint unkn0;
    public float unkn1;
    public float unkn2;
    public float unkn3;
    public float unkn4;
    public float unkn5;
	[RszConditional(nameof(Version), '>', EfxVersion.DMC5)]
    public float unkn6;

}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.Noise, EfxVersion.RE4)]
public partial class EFXAttributeNoise : EFXAttribute
{
	public EFXAttributeNoise() : base(EfxAttributeType.Noise) { }

	public float unkn1_0;
	public float unkn1_1;
	public float unkn1_2;
	public float unkn1_3;
	public float unkn1_4;
	public float unkn1_5;
	public float unkn1_6;
	public float unkn1_7;

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.PlayEfx, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributePlayEfx : EFXAttribute
{
	public EFXAttributePlayEfx() : base(EfxAttributeType.PlayEfx) { }

	[RszInlineWString] public string? efxPath;
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.ProceduralDistortion, EfxVersion.RE4)]
public partial class EFXAttributeProceduralDistortion : EFXAttribute
{
	public EFXAttributeProceduralDistortion() : base(EfxAttributeType.ProceduralDistortion) { }

	public uint unkn1;
	public float unkn2_0;
	public float unkn2_1;
	public float unkn2_2;
	public float unkn2_3;
	public float unkn2_4;
	public float unkn2_5;
	public float unkn2_6;
	public float unkn2_7;
	public float unkn2_8;
	public float unkn2_9;
	public float unkn2_10;
	public float unkn2_11;
	public float unkn2_12;
	public float unkn2_13;
	public float unkn2_14;
	public float unkn2_15;
	public float unkn2_16;
	public float unkn2_17;

}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.ProceduralDistortionDelayFrame, EfxVersion.RE4)]
public partial class EFXAttributeProceduralDistortionDelayFrame : EFXAttribute
{
	public EFXAttributeProceduralDistortionDelayFrame() : base(EfxAttributeType.ProceduralDistortionDelayFrame) { }

	public uint frameDelay;
	public uint null1;

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.ProceduralDistortionExpression, EfxVersion.RE4)]
public partial class EFXAttributeProceduralDistortionExpression : EFXAttribute
{
	public EFXAttributeProceduralDistortionExpression() : base(EfxAttributeType.ProceduralDistortionExpression) { }

	public uint unkn1_0;
	public uint unkn1_1;
	public uint unkn1_2;
	public uint unkn1_3;
	public uint unkn1_4;
	public uint unkn1_5;
	public uint unkn1_6;
	public uint unkn1_7;
	public uint unkn1_8;
	public uint unkn1_9;
	public uint unkn1_10;
	public uint unkn1_11;
	public uint unkn1_12;
	public uint unkn1_13;
	public uint unkn1_14;
	public uint unkn1_15;
	public uint unkn1_16;
	public uint unkn1_17;
	public uint unkn1_18;
	[RszClassInstance] public EFXExpressionListWrapper expressions = new();

}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.PtColor, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributePtColor : EFXAttribute
{
	public EFXAttributePtColor() : base(EfxAttributeType.PtColor) { }

	public uint unkn1;
	public uint unkn2;
	public via.Color color0;

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.PtLife, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributePtLife : EFXAttribute
{
	public EFXAttributePtLife() : base(EfxAttributeType.PtLife) { }

	public uint unkn1_0;
	public uint unkn1_1;
	public int actionIndex;

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.PtSort, EfxVersion.RE4)]
public partial class EFXAttributePtSort : EFXAttribute
{
	public EFXAttributePtSort() : base(EfxAttributeType.PtSort) { }

	public uint null1;

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.PtTransform3D, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributePtTransform3D : EFXAttribute
{
	public EFXAttributePtTransform3D() : base(EfxAttributeType.PtTransform3D) { }

	public uint null1_0;
	public uint null1_1;
	public uint null1_2;
	public uint null1_3;
	public uint null1_4;
	public uint null1_5;
	public float unkn1_6;
	public float unkn1_7;
	public float unkn1_8;

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.PtUvSequence, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributePtUvSequence : EFXAttribute
{
	public EFXAttributePtUvSequence() : base(EfxAttributeType.PtUvSequence) { }

	public uint unkn1_0;
	public uint null1_1;
	public uint null1_2;
	[RszConditional(nameof(Version), "<=", EfxVersion.DMC5)]
	public uint null1_3;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.PtVelocity3D, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributePtVelocity3D : EFXAttribute
{
	public EFXAttributePtVelocity3D() : base(EfxAttributeType.PtVelocity3D) { }

	public uint null1_0;
	public float unkn1_1;
	public uint null1_2;
	public float unkn1_3;

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.RenderTarget, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeRenderTarget : EFXAttribute
{
	public EFXAttributeRenderTarget() : base(EfxAttributeType.RenderTarget) { }

	public uint null1;
	[RszInlineWString] public string? rtexPath;

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.RgbCommon, EfxVersion.RE4)]
public partial class EFXAttributeRgbCommon : EFXAttribute
{
	public EFXAttributeRgbCommon() : base(EfxAttributeType.RgbCommon) { }

	[RszConditional(nameof(Version), ">=", EfxVersion.RE4), RszFixedSizeArray(4)] public uint[]? re4_unkn;

	public via.Color color0;
	public float unkn1_0;
	public float unkn1_1;
	public float unkn1_2;
	public via.Color unkn1_3;
	public float unkn1_4;
	public float unkn1_5;
	public float unkn1_6;
	public uint null1_7;
	public uint null1_8;
	public uint null1_9;
	public uint null1_10;
	public uint null1_11;
	public uint null1_12;
	public uint null1_13;
	public uint null1_14;
	public uint null1_15;
	public uint null1_16;
	public uint null1_17;
	public uint null1_18;
	public uint null1_19;
	public uint unkn1_20;
	public uint null1_21;

}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.RotateAnim, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeRotateAnim : EFXAttribute
{
	public EFXAttributeRotateAnim() : base(EfxAttributeType.RotateAnim) { }

	public uint unkn1_0;
	public float rotateSpeedX;
	public float rotateSpeedXRandom;
	public float rotateSpeedY;
	public float rotateSpeedYRandom;
	public float rotateSpeedZ;
	public float rotateSpeedZRandom;
	public float unkn4_2;
	public float unkn4_3;
	public float unkn4_4;
	public float unkn4_5;
	public float unkn4_6;
	public float unkn4_7;


}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.RotateAnimDelayFrame, EfxVersion.RE4)]
public partial class EFXAttributeRotateAnimDelayFrame : EFXAttribute
{
	public EFXAttributeRotateAnimDelayFrame() : base(EfxAttributeType.RotateAnimDelayFrame) { }

	public uint frameDelay;
	public uint unkn2;

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.RotateAnimExpression, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeRotateAnimExpression : EFXAttribute
{
	public EFXAttributeRotateAnimExpression() : base(EfxAttributeType.RotateAnimExpression) { }

    [RszFixedSizeArray(13)] public uint[]? unkn2;
	[RszClassInstance] public EFXExpressionListWrapper expressions = new();
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.ScaleAnim, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeScaleAnim : EFXAttribute
{
	public EFXAttributeScaleAnim() : base(EfxAttributeType.ScaleAnim) { }

	public float minScale;
	public float unkn1_1;
	public float maxScale;
	public float unkn1_3;
	public float unkn1_4;
	public float unkn1_5;
	public float unkn1_6;
	public float unkn1_7;
	public float unkn1_8;
	public float unkn1_9;
	public float unkn1_10;
	public float unkn1_11;
	public float unkn1_12;
	public float unkn1_13;
	public float unkn1_14;
	public float unkn1_15;
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.ScaleAnimDelayFrame, EfxVersion.RE4)]
public partial class EFXAttributeScaleAnimDelayFrame : EFXAttribute
{
	public EFXAttributeScaleAnimDelayFrame() : base(EfxAttributeType.ScaleAnimDelayFrame) { }

	public uint frameDelay;
	public uint unkn2;

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.ScaleAnimExpression, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeScaleAnimExpression : EFXAttribute
{
	public EFXAttributeScaleAnimExpression() : base(EfxAttributeType.ScaleAnimExpression) { }

	public uint unkn1;
	public uint unkn2;
	public uint unkn3;
    [RszConditional(nameof(Version), ">=", EfxVersion.RERT, EndAt = nameof(sb_unkn5))]
	public uint sb_unkn0;
	public uint sb_unkn1;
	public uint sb_unkn2;
	public uint sb_unkn3;
	public uint sb_unkn4;
	public uint sb_unkn5;

	[RszClassInstance] public EFXExpressionListWrapper expressions = new();

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.ScaleByDepth, EfxVersion.RE4)]
public partial class EFXAttributeScaleByDepth : EFXAttribute
{
	public EFXAttributeScaleByDepth() : base(EfxAttributeType.ScaleByDepth) { }

	public uint unkn1;
	public float unkn2_0;
	public float unkn2_1;
	public float unkn2_2;
	public float unkn2_3;
	public float unkn2_4;
	public float unkn2_5;

}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.ShaderSettings, EfxVersion.RERT, EfxVersion.RE4)]
public partial class EFXAttributeShaderSettings : EFXAttribute
{
	public EFXAttributeShaderSettings() : base(EfxAttributeType.ShaderSettings) { }

	public float unkn1;
	public uint unkn2;
    [RszConditional(nameof(Version), ">=", EfxVersion.RERT, EndAt = nameof(sb_unkn1))]
	public float sb_unkn0;
	public float sb_unkn1;

	public float unkn3;
	public uint unkn4;
	public uint unkn5;
	public float unkn6;
	public float unkn7;
	public float unkn8;
	public float unkn9;
	public float unkn10;
	public float unkn11;
	public uint unkn12;
	public uint unkn13;
	public uint null14;
	public float null15;
	public float null16;
	public float unkn17;
	public uint unkn18;
    [RszConditional(nameof(Version), ">=", EfxVersion.RERT, EndAt = nameof(sb_unkn5))]
	public uint sb_unkn2;
	public float sb_unkn3;
	public uint sb_unkn4;
	public uint sb_unkn5;

	public float unkn19;
    [RszConditional(nameof(Version), ">", EfxVersion.DMC5, EndAt = nameof(re4_unkn))]
	public float null20;
	public float null21;
	public float null22;
	public float null23;
	public float unkn24;

    [RszConditional(nameof(Version), ">=", EfxVersion.RERT, EndAt = nameof(sb_unkn12))]
	public uint sb_unkn6;
	public uint sb_null7;
	public uint sb_unkn8;
    [RszConditional(nameof(Version), ">", EfxVersion.RERT, EndAt = nameof(sb_unkn12))]
	public uint sb_unkn9;
	public uint sb_unkn10;
	public uint sb_unkn11;
	public uint sb_unkn12;

    [RszConditional(nameof(Version), ">=", EfxVersion.RE4), RszFixedSizeArray(4)] public uint[]? re4_unkn;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.SpawnExpression, EfxVersion.RERT, EfxVersion.RE4)]
public partial class EFXAttributeSpawnExpression : EFXAttribute
{
	public EFXAttributeSpawnExpression() : base(EfxAttributeType.SpawnExpression) { }

	public uint flags;
	ExpressionOperator spawnNum;
	ExpressionOperator spawnNumRange;
	ExpressionOperator intervalFrame;
	ExpressionOperator intervalFrameRange;
	ExpressionOperator emitterDelayFrame;
	ExpressionOperator emitterDelayFrameRange;
    [RszConditional(nameof(Version), ">=", EfxVersion.RERT)]
	ExpressionOperator sb_unkn0;

	[RszClassInstance] public EFXExpressionListWrapper expressions = new();
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.StretchBlur, EfxVersion.RE4)]
public partial class EFXAttributeStretchBlur : EFXAttribute
{
	public EFXAttributeStretchBlur() : base(EfxAttributeType.StretchBlur) { }

    public uint blurRotation;
    public uint two;//<comment="Doesn't seem to work when this value isn't two">;
    public float blurAmount;
    public float unkn4;
    public float unkn5;
    public float unknBlurScaleX;
    public float unknBlurScaleY;
    public float blurOpacity;
    public float unkn9;
    public float unkn10;
    public float unkn11;
    public float unkn12;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TexelChannelOperator, EfxVersion.RE4)]
public partial class EFXAttributeTexelChannelOperator : EFXAttribute
{
	public EFXAttributeTexelChannelOperator() : base(EfxAttributeType.TexelChannelOperator) { }

	public uint unkn1_0;
	public float unkn1_1;
	public via.Color unkn1_2;
	public float unkn1_3;
	public float unkn1_4;
	public float unkn1_5;
	public float unkn1_6;
	public float unkn1_7;
	public float unkn1_8;
	public float unkn1_9;
	public uint unkn1_10;
	public uint unkn1_11;
	public uint unkn1_12;
	public uint unkn1_13;
	public uint unkn1_14;
	public uint unkn1_15;
	public uint unkn1_16;

}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TextureFilter, EfxVersion.RE4)]
public partial class EFXAttributeTextureFilter : EFXAttribute
{
	public EFXAttributeTextureFilter() : base(EfxAttributeType.TextureFilter) { }

	public float unkn1;
	public float unkn2;
	public float unkn3;

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TextureUnit, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeTextureUnit : EFXAttribute
{
	public EFXAttributeTextureUnit() : base(EfxAttributeType.TextureUnit) { }

	public uint unkn1_0;
	public uint unkn1_1;
	public int unkn1_2;
	public float unkn1_3;
	public uint null1_4;
	public uint null1_5;
	public float unkn1_6;
	public uint null1_7;
	public float unkn1_8;
	public uint null1_9;
	public float unkn1_10;
	public uint null1_11;
	public float unkn1_12;
	public uint null1_13;
	public float unkn1_14;
	public uint null1_15;
	public float unkn1_16;
	public uint null1_17;
	public uint null1_18;
	public uint null1_19;
	public float unkn1_20;
	public uint null1_21;
	public float unkn1_22;
	public uint null1_23;
	public float unkn1_24;
	public uint null1_25;
	public uint null1_26;
	public uint null1_27;
	public float unkn1_28;
	public uint null1_29;
	public float unkn1_30;
	public uint null1_31;
	public float unkn1_32;
	public uint null1_33;
	public uint null1_34;
	public uint null1_35;
	public uint null1_36;
	public uint null1_37;
	public float unkn1_38;
	public float unkn1_39;
	public uint unkn1_40;
	public int unkn1_41;
	public float unkn1_42;
	public uint null1_43;
	public float unkn1_44;
	public float unkn1_45;
	public float unkn1_46;
	public float unkn1_47;
	public uint null1_48;
	public float unkn1_49;
	public uint null1_50;
	public float unkn1_51;
	public uint null1_52;
	public float unkn1_53;
	public uint null1_54;
	public uint null1_55;
	public float unkn1_56;
	public uint null1_57;
	public uint null1_58;
	public float unkn1_59;
	public uint null1_60;
	public float unkn1_61;
	public uint null1_62;
	public float unkn1_63;
	public uint null1_64;
	public float unkn1_65;
	public uint null1_66;
	public float unkn1_67;
	public uint null1_68;
	public float unkn1_69;
	public uint null1_70;
	public float unkn1_71;
	public uint null1_72;
	public uint null1_73;
	public uint unkn1_74;
	public uint null1_75;
	public uint null1_76;
	public float unkn1_77;
	public float unkn1_78;
	public uint unkn1_79;
	public int unkn1_80;
	public float unkn1_81;
	public float unkn1_82;
	public float unkn1_83;
	public uint null1_84;
	public float unkn1_85;
	public uint null1_86;
	public uint null1_87;
	public float unkn1_88;
	public uint null1_89;
	public float unkn1_90;
	public uint null1_91;
	public float unkn1_92;
	public uint null1_93;
	public uint null1_94;
	public uint null1_95;
	public uint null1_96;
	public uint null1_97;
	public float unkn1_98;
	public uint null1_99;
	public float unkn1_100;
	public uint null1_101;
	public float unkn1_102;
	public uint null1_103;
	public float unkn1_104;
	public uint null1_105;
	public float unkn1_106;
	public uint null1_107;
	public float unkn1_108;
	public uint null1_109;
	public float unkn1_110;
	public uint null1_111;
	public uint null1_112;
	public uint null1_113;
	public uint null1_114;
	public uint null1_115;
	public float unkn1_116;
	public float unkn1_117;
	public uint uvs0PathCharCount;
	public uint uvs1PathCharCount;
	public uint uvs2PathCharCount;
	[RszInlineWString(nameof(uvs0PathCharCount))] public string? uvs0Path;
	[RszInlineWString(nameof(uvs1PathCharCount))] public string? uvs1Path;
	[RszInlineWString(nameof(uvs2PathCharCount))] public string? uvs2Path;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypeBillboard2DExpression, EfxVersion.RERT, EfxVersion.RE4)]
public partial class EFXAttributeTypeBillboard2DExpression : EFXAttribute
{
	public EFXAttributeTypeBillboard2DExpression() : base(EfxAttributeType.TypeBillboard2DExpression) { }

	public uint unkn1_0;
	public uint unkn1_1;
	public uint unkn1_2;
	[RszConditional(nameof(Version), ">", EfxVersion.DMC5, EndAt = nameof(unkn1_13))]
	public uint unkn1_3;
	public uint unkn1_4;
	public uint unkn1_5;
    public uint unkn1_6;
    public uint unkn1_7;
    public uint unkn1_8;
    public uint unkn1_9;
    public uint unkn1_10;
    public uint unkn1_11;
    public uint unkn1_12;
	[RszConditional(nameof(Version), ">", EfxVersion.RERT)]
    public uint unkn1_13;
	[RszClassInstance] public EFXExpressionListWrapper expressions = new();
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypeBillboard3D, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeTypeBillboard3D : EFXAttribute
{
	public EFXAttributeTypeBillboard3D() : base(EfxAttributeType.TypeBillboard3D) { }

	public uint unkn1;
	public via.Color color0;
	public via.Color color1;
	public float unknOpacityValue;

	public float ColorRate; // 1
	public float AlphaRate;
	public float Rotation;
	public float RotationVariation;
	public float SizeScaler;
	public float SizeScalerVariation;
	public float SizeX;
	public float SizeXVariation;
	public float SizeY;
	public float SizeYVariation; // 10

    public float unkn13;
	[RszConditional(nameof(Version), ">=", EfxVersion.RERT)]
	public float sb_unkn0;

	public float unkn14;
    public float unkn15;
	public float unkn16;

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypeBillboard3DExpression, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeTypeBillboard3DExpression : EFXAttribute
{
	public EFXAttributeTypeBillboard3DExpression() : base(EfxAttributeType.TypeBillboard3DExpression) { }

    [RszConditional(nameof(Version), ">=", EfxVersion.RE4)]
	public uint re4_unkn0;

	public uint unkn1_0;
	public uint unkn1_1;
	public uint unkn1_2;
	public uint unkn1_3;
	public uint unkn1_4;
	public uint unkn1_5;
	public uint unkn1_6;
	public uint unkn1_7;
	public uint unkn1_8;
    [RszConditional(nameof(Version), ">", EfxVersion.DMC5, EndAt = nameof(unkn1_12))]
	public uint unkn1_9;
	public uint unkn1_10;
	public uint unkn1_11;
	public uint unkn1_12;
    [RszConditional(nameof(Version), ">=", EfxVersion.DD2), RszFixedSizeArray(4)]
	public uint[]? dd2_unkn2;

	[RszClassInstance] public EFXExpressionListWrapper expressions = new();

}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypeGpuBillboard, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeTypeGpuBillboard : EFXAttribute
{
	public EFXAttributeTypeGpuBillboard() : base(EfxAttributeType.TypeGpuBillboard) { }

	public uint unkn1;
	public uint unkn2;
    [RszConditional(nameof(Version), ">=", EfxVersion.RERT)]
	public uint unkn3;
	public via.Color color0;
	public via.Color color1;
	public float emission;
	public float unkn5;
	public float unkn6;
	public float unkn7;
	public float unkn8;
	public float effectScale;
	public float unkn10;
	public float unkn11;

    [RszConditional(nameof(Version), ">=", EfxVersion.RERT, EndAt = nameof(sb_unkn7))]
	public float sb_unkn0;
	public float sb_unkn1;
	public float sb_unkn2;
	public float sb_unkn3;
	public float sb_unkn4;
	public float sb_unkn5;
	public float sb_unkn6; // RERT
	public float sb_unkn7; // RERT

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypeGpuBillboardExpression, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeTypeGpuBillboardExpression : EFXAttribute
{
	public EFXAttributeTypeGpuBillboardExpression() : base(EfxAttributeType.TypeGpuBillboardExpression) { }

	public uint unkn1_0;
	public uint unkn1_1;
	public uint unkn1_2;
	public uint unkn1_3;
	public uint unkn1_4;
	public uint unkn1_5;
	public uint unkn1_6;
	public uint unkn1_7;
    [RszConditional(nameof(Version), ">=", EfxVersion.RERT, EndAt = nameof(sb_unkn5))]
	public uint sb_unkn0;
	public uint sb_unkn1;
	public uint sb_unkn2;
	public uint sb_unkn3;
	public uint sb_unkn4;
	public uint sb_unkn5;

	[RszClassInstance] public EFXExpressionListWrapper expressions = new();

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypeGpuLightning3D, EfxVersion.RE4)]
public partial class EFXAttributeTypeGpuLightning3D : EFXAttribute
{
	public EFXAttributeTypeGpuLightning3D() : base(EfxAttributeType.TypeGpuLightning3D) { }

	public uint unkn1;
	public via.Color color0;
	public via.Color color1;
	public int unkn2_0;
	public float unkn2_1;
	public uint null2_2;
	public uint null2_3;
	public float unkn2_4;
	public uint unkn2_5;
	public uint unkn2_6;
	public uint null2_7;
	public float unkn2_8;
	public uint null2_9;
	public float unkn2_10;
	public uint null2_11;
	public float unkn2_12;
	public float unkn2_13;
	public uint null2_14;
	public float unkn2_15;
	public uint null2_16;
	public float unkn2_17;
	public uint null2_18;
	public float unkn2_19;
	public uint null2_20;
	public uint null2_21;
	public uint null2_22;
	public uint null2_23;
	public uint null2_24;
	public uint null2_25;
	public uint null2_26;
	public uint null2_27;
	public float unkn2_28;
	public uint null2_29;
	public uint null2_30;
	public float unkn2_31;
	public float unkn2_32;
	public uint null2_33;
	public float unkn2_34;
	public float unkn2_35;
	public float unkn2_36;
	public uint unkn2_37;
	public uint unkn2_38;
	public float unkn2_39;
	public float unkn2_40;
	public uint unkn2_41;
	public float unkn2_42;
	public float unkn2_43;
	public float unkn2_44;
	public float unkn2_45;
	public float unkn2_46;
	public float unkn2_47;
	public uint unkn2_48;
	public uint unkn2_49;
	public uint null2_50;
	public uint null2_51;
	public uint null2_52;
	public uint null2_53;
	public uint unkn2_54;
	public float unkn2_55;
	public float unkn2_56;
	public float unkn2_57;
	public float unkn2_58;
	public float unkn2_59;
	public float unkn2_60;
	public uint unkn2_61;
	public uint unkn2_62;
	public uint null2_63;
	public uint null2_64;
	public uint null2_65;
	public uint null2_66;
	public uint unkn2_67;
	public float unkn2_68;
	public float unkn2_69;
	public float unkn2_70;
	public float unkn2_71;
	public float unkn2_72;
	public float unkn2_73;
	public uint null2_74;
	public uint null2_75;
	public uint null2_76;
	public uint null2_77;
	public uint null2_78;
	public uint null2_79;
	public uint unkn2_80;
	public uint unkn2_81;
	public uint unkn2_82;
	public uint unkn2_83;
	public uint null2_84;
	ushort unkn3;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypeGpuPolygon, EfxVersion.RE4)]
public partial class EFXAttributeTypeGpuPolygon : EFXAttribute
{
	public EFXAttributeTypeGpuPolygon() : base(EfxAttributeType.TypeGpuPolygon) { }

	public uint unkn1;
	public uint unkn2;
	public uint unkn3;
	public via.Color color0;
	public via.Color color1;
	public float unkn4_0;
	public float unkn4_1;
	public float unkn4_2;
	public uint unkn4_3;
	public float unkn4_4;
	public uint null4_5;
	public float unkn4_6;
	public uint null4_7;
	public float unkn4_8;
	public float unkn4_9;
	[RszConditional(nameof(Version), '>', EfxVersion.RERT, EndAt = nameof(unkn4_15))]
	public float unkn4_10;
	public float unkn4_11;
	public float unkn4_12;
	public float unkn4_13;
	public float unkn4_14;
	public float unkn4_15;

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypeGpuRibbonFollow, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeTypeGpuRibbonFollow : EFXAttribute
{
	public EFXAttributeTypeGpuRibbonFollow() : base(EfxAttributeType.TypeGpuRibbonFollow) { }

	public uint unkn1_0;
	public uint unkn1_1;
	public uint unkn1_2;
	public uint unkn1_3;
	[RszConditional(nameof(Version), '>', EfxVersion.DMC5)]
	public uint unkn1_4;
	public via.Color color0;
	public via.Color color1;
	public float unkn2_0;

	public float unkn2_1;
	public uint null2_2;
	public float unkn2_3;
	public float unkn2_4;
	public float unkn2_5;
	public float unkn2_6;
	[RszConditional(nameof(Version), '>', EfxVersion.DMC5)]
	public float unkn2_7;
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypeGpuRibbonLength, EfxVersion.RE4)]
public partial class EFXAttributeTypeGpuRibbonLength : EFXAttribute
{
	public EFXAttributeTypeGpuRibbonLength() : base(EfxAttributeType.TypeGpuRibbonLength) { }

	public uint unkn1;
	public uint unkn2;
	public via.Color color0;
	public via.Color color1;
	public float unkn3_0;
	public float unkn3_1;
	public uint null3_2;
	public float unkn3_3;
	public float unkn3_4;
	public float unkn3_5;
	public float unkn3_6;
	public float unkn3_7;
	public float unkn3_8;
	public uint unkn3_9;
	public float unkn3_10;
	public float unkn3_11;
	public uint unkn3_12;
	public float unkn3_13;
	public float unkn3_14;
	public uint null3_15;
	public uint null3_16;
	public float unkn3_17;
	public uint null3_18;
	public float unkn3_19;
	public uint null3_20;
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypeLightning3D, EfxVersion.RE4)]
public partial class EFXAttributeTypeLightning3D : EFXAttribute, IBoneRelationAttribute
{
	public EFXAttributeTypeLightning3D() : base(EfxAttributeType.TypeLightning3D) { }

	public uint unknBitFlag;//<comment="The va	lues change between base game and sunbreak, even on files that have no changes. Game will crash when value is set wrong.">;
	public via.Color color0;
	public via.Color color1;
	public float unkn2_0;
	public float unkn2_1;
	public float unkn2_2;
	public float unkn2_3;
	[RszConditional(nameof(Version), ">=", EfxVersion.RERT)]
	public float sb_unkn0;

    public float unkn2_4;
	public float unkn2_5;
	public float unkn2_6;
	public float unkn2_7;
	public float unkn2_8;
	public float unkn2_9;
	public uint unkn2_10;
	public uint unkn2_11;
	public uint unkn2_12;
	public float unkn2_13;
	public float unkn2_14;
	public float unkn2_15;
	public float unkn2_16;
	public float unkn2_17;
	public float unkn2_18;
	public float unkn2_19;
	public float unkn2_20;
	public float unkn2_21;
	public float unkn2_22;
	public float unkn2_23;
	public float unkn2_24;
	public float unkn2_25;
	public float unkn2_26;
	public float unkn2_27;
	public float unkn2_28;
	public float unkn2_29;
	public float unkn2_30;
	public float unkn2_31;
	public float unkn2_32;
	public float unkn2_33;
	public float unkn2_34;
	public float unkn2_35;
	public float unkn2_36;
	public float unkn2_37;
	public float unkn2_38;
	public float unkn2_39;
	public float unkn2_40;
	public float unkn2_41;
	public float unkn2_42;
	public float unkn2_43;
	public float unkn2_44;
	public float unkn2_45;
	public float unkn2_46;
	public float unkn2_47;
	public uint unkn2_48;
	public uint unkn2_49;
	public float unkn2_50;
	public float unkn2_51;
	public float unkn2_52;
	public float unkn2_53;
	public float unkn2_54;
	public float unkn2_55;
	public float unkn2_56;
	public float unkn2_57;
	public float unkn2_58;
	public float unkn2_59;
	public float unkn2_60;
	public float unkn2_61;
	public float unkn2_62;
	public float unkn2_63;
	public uint unkn2_64;
	public uint unkn2_65;
	public uint unkn2_66;
	public float null2_67;
	public float unkn2_68;
	public float unkn2_69;
	public uint unkn2_70;

	public float unkn2_71;
	public float unkn2_72;
	[RszInlineWString] public string? boneName;

    public string? ParentBone { get; set; }
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypeLightning3DExpression, EfxVersion.RE4)]
public partial class EFXAttributeTypeLightning3DExpression : EFXAttribute
{
	public EFXAttributeTypeLightning3DExpression() : base(EfxAttributeType.TypeLightning3DExpression) { }

	public uint unkn1_0;
	public uint unkn1_1;
	public uint unkn1_2;
	public uint unkn1_3;
	public uint unkn1_4;
	public uint unkn1_5;
	public uint unkn1_6;
	public uint unkn1_7;
	public uint unkn1_8;
	public uint unkn1_9;
	public uint unkn1_10;
	public uint unkn1_11;
	public uint unkn1_12;
	public uint unkn1_13;
	public uint unkn1_14;
	public uint unkn1_15;
	public uint unkn1_16;
	public uint unkn1_17;
	public uint unkn1_18;
	public uint unkn1_19;
	public uint unkn1_20;
	public uint unkn1_21;
	public uint unkn1_22;
	public uint unkn1_23;
	public uint unkn1_24;
	public uint unkn1_25;
	public uint unkn1_26;
	public uint unkn1_27;
	public uint unkn1_28;
	public uint unkn1_29;
	[RszClassInstance] public EFXExpressionListWrapper expressions = new();

}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypeNoDrawExpression, EfxVersion.RE4)]
public partial class EFXAttributeTypeNoDrawExpression : EFXAttribute
{
	public EFXAttributeTypeNoDrawExpression() : base(EfxAttributeType.TypeNoDrawExpression) { }

    [RszFixedSizeArray(15)] public uint[]? unkn0;
	[RszConditional(nameof(Version), '>', EfxVersion.DMC5, EndAt = nameof(unkn2))]
    public uint unkn1;
    public uint unkn2;
	[RszClassInstance] public EFXExpressionListWrapper expressions = new();
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypeNodeBillboard, EfxVersion.RERT, EfxVersion.RE4)]
public partial class EFXAttributeTypeNodeBillboard : EFXAttribute
{
	public EFXAttributeTypeNodeBillboard() : base(EfxAttributeType.TypeNodeBillboard) { }

	public uint unkn1_0;
	public uint unkn1_1;
	public uint unkn1_2;
	public uint unkn1_3;
	public float unkn1_4;
	public float unkn1_5;
	public float unkn1_6;
	public float unkn1_7;
	public float unkn1_8;
	public float unkn1_9;
	public via.Color color0;
	public uint unkn1_11;
	public float unkn1_12;
	public float unkn1_13;
	public float unkn1_14;
	public float unkn1_15;
	public float unkn1_16;
	public float unkn1_17;
	public float unkn1_18;
	public float unkn1_19;
	public float unkn1_20;
	public via.Color color1;
	public int unkn1_22;
	public float unkn1_23;
	public float unkn1_24;
	public float unkn1_25;
	public float unkn1_26;
	public float unkn1_27;
	public float unkn1_28;
	public float unkn1_29;
	public float unkn1_30;
	public float unkn1_31;
	public via.Color color2;
	public int unkn1_33;
	public float unkn1_34;
	public float unkn1_35;
	public float unkn1_36;
	public float unkn1_37;
	public float unkn1_38;
	public float unkn1_39;
	public float unkn1_40;
	public float unkn1_41;
	public float unkn1_42;
	public via.Color color3;
	public int unkn1_44;
	public float unkn1_45;
	public float unkn1_46;
	public float unkn1_47;
	public uint null1_48;
	public float unkn1_49;
	public float unkn1_50;
	public float unkn1_51;
	public uint unkn1_52;
	public float unkn1_53;
	public float unkn1_54;
	public float unkn1_55;
	public float unkn1_56;
	public uint unkn1_57;
	public uint unkn1_58;
	public uint unkn1_59;
	public uint unkn1_60;
	public float unkn1_61;

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypeNodeBillboardExpression, EfxVersion.DMC5, EfxVersion.RERT, EfxVersion.RE4)]
public partial class EFXAttributeTypeNodeBillboardExpression : EFXAttribute
{
	public EFXAttributeTypeNodeBillboardExpression() : base(EfxAttributeType.TypeNodeBillboardExpression) { }

	public uint unkn1_0;
	public uint unkn1_1;
	public uint unkn1_2;
	public uint unkn1_3;
	public uint unkn1_4;
	public uint unkn1_5;
	public uint unkn1_6;
	public uint unkn1_7;
	public uint unkn1_8;
	public uint unkn1_9;
	public uint unkn1_10;
	public uint unkn1_11;
	public uint unkn1_12;
	public uint unkn1_13;
	public uint unkn1_14;
	public uint unkn1_15;
	public uint unkn1_16;
	public uint unkn1_17;
	public uint unkn1_18;
	public uint unkn1_19;
	public uint unkn1_20;
	public uint unkn1_21;
	public uint unkn1_22;
	public uint unkn1_23;
	public uint unkn1_24;
	public uint unkn1_25;
	public uint unkn1_26;
	public uint unkn1_27;
	public uint unkn1_28;
	public uint unkn1_29;
	public uint unkn1_30;
	public uint unkn1_31;
	public uint unkn1_32;
	public uint unkn1_33;
	public uint unkn1_34;
	public uint unkn1_35;
	public uint unkn1_36;
	public uint unkn1_37;
	public uint unkn1_38;
	public uint unkn1_39;
	public uint unkn1_40;
	public uint unkn1_41;
	public uint unkn1_42;
	public uint unkn1_43;
	[RszClassInstance] public EFXExpressionListWrapper expressions = new();
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypePolygon, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeTypePolygon : EFXAttribute
{
	public EFXAttributeTypePolygon() : base(EfxAttributeType.TypePolygon) { }

	public uint mFlags;
	public via.Color color0;
	public via.Color color1;
    public float unkn2;

	public int unkn3;
	public uint unkn4_0;
	public uint unkn4_1;

	public float unkn4_2;
	[RszConditional(nameof(Version), ">=", EfxVersion.RE4)]
	public uint re4_unkn0;

    public float unkn4_3;
	public float unkn4_4;
	public float unkn4_5;
	public float unkn4_6;
	public float unkn4_7;
	public float unkn4_8;
	public float unkn4_9;
	public float unkn4_10;
	public float unkn4_11;
	public float unkn4_12;
	public float unkn4_13;
	public float unkn4_14;
	public float unkn4_15;
	public float unkn4_16;
    [RszConditional(nameof(Version), ">=", EfxVersion.RERT)]
	public float sb_unkn0;
    [RszConditional(nameof(Version), ">=", EfxVersion.RE4)]
	public float re4_unkn1;
	// [RszFixedSizeArray(20)] public uint[]? re4_unkn2;
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypePolygonExpression, EfxVersion.RE4)]
public partial class EFXAttributeTypePolygonExpression : EFXAttribute
{
	public EFXAttributeTypePolygonExpression() : base(EfxAttributeType.TypePolygonExpression) { }

	public uint unkn1_0;
	public uint unkn1_1;
	public uint unkn1_2;
	public uint unkn1_3;
	public uint unkn1_4;
	public uint unkn1_5;
	public uint unkn1_6;
	public uint unkn1_7;
	public uint unkn1_8;
	public uint unkn1_9;
	public uint unkn1_10;
	public uint unkn1_11;
	public uint unkn1_12;
	public uint unkn1_13;
	public uint unkn1_14;
	public uint unkn1_15;
	public uint unkn1_16;
	public uint unkn1_17;
	public uint unkn1_18;
	[RszConditional(nameof(Version), '>', EfxVersion.DMC5)]
	public uint unkn1_19;
	[RszClassInstance] public EFXExpressionListWrapper expressions = new();

}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknRE4Struct70, EfxVersion.RE4)]
public partial class EFXAttributeunknRE4Struct70 : EFXAttribute
{
	public EFXAttributeunknRE4Struct70() : base(EfxAttributeType.unknRE4Struct70) { }

    [RszFixedSizeArray(12)] public uint[]? unkn1;
    [RszConditional(nameof(Version), ">=", EfxVersion.RE4), RszFixedSizeArray(10)] public uint[]? unkn2_re4;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypePolygonTrail, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeTypePolygonTrail : EFXAttribute
{
	public EFXAttributeTypePolygonTrail() : base(EfxAttributeType.TypePolygonTrail) { }

	public uint unkn1;
	public via.Color color0;
	public via.Color color1;
	public float unkn4;

	public float unkn5;
	public float unkn6;
	public float unkn7;
    [RszConditional(nameof(Version), ">=", EfxVersion.RERT)]
	public float sb_unkn0;

	public uint unkn8;
	public float unkn9;
	public float unkn10;
	public float unkn11;
	public uint unkn12;
	public uint unkn13;
	public uint unkn14;
	public uint unkn15;
	public int unkn16;
	public int unkn17;
	public int unkn18;
	public float unkn19;
	public float unkn20;
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypeRibbonFixEnd, EfxVersion.RE4)]
public partial class EFXAttributeTypeRibbonFixEnd : EFXAttribute
{
	public EFXAttributeTypeRibbonFixEnd() : base(EfxAttributeType.TypeRibbonFixEnd) { }

	public uint unkn1;
	public via.Color color0;
	public via.Color color1;
	public float unkn2_0;
	public float unkn2_1;
	public uint null2_2;
	public float unkn2_3;
	public float unkn2_4;
	public float unkn2_5;
	public uint unkn2_6;
	public float unkn2_7;
	public float unkn2_8; // 12
	[RszConditional(nameof(Version), ">=", EfxVersion.RERT)]
	public float sb_unkn0;
    [RszConditional(nameof(Version), ">=", EfxVersion.RE4)]
	public float re4_unkn0;
    public uint unkn2_9;
	public float unkn2_10;
	public float unkn2_11;
	public uint unkn2_12;
	public uint unkn2_13;
	public uint unkn2_14;
	public float unkn2_15;
	public int unkn2_16;//20
	public int unkn2_17;
	public int unkn2_18;
	public float unkn2_19;
	public float unkn2_20;
	public float unkn2_21;
	public float unkn2_22;
	public float unkn2_23;
	public float unkn2_24;
	public float unkn2_25;//29
    [RszConditional(nameof(Version), ">", EfxVersion.DMC5, EndAt = nameof(unkn2_27))]
	public float unkn2_26;
	public float unkn2_27;

}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypeRibbonFollow, EfxVersion.RERT, EfxVersion.RE4)]
public partial class EFXAttributeTypeRibbonFollow : EFXAttribute
{
	public EFXAttributeTypeRibbonFollow() : base(EfxAttributeType.TypeRibbonFollow) { }

	public uint emission;
	public via.Color color0;
	public via.Color color1;
	public float unkn4;
	public float unkn5;
	public float unkn6;
	public float unkn7;
	public uint unkn8;
	public float unkn9;
	public uint unkn10;
	public float trailWidth;
	public float unkn12;
	[RszConditional(nameof(Version), ">=", EfxVersion.RERT)]
	public float sb_unkn0;
    public uint unkn13;
	public float unkn14;
	public float unkn15;
	public uint unkn16;
	public uint trailLength;
    [RszConditional(nameof(Version), ">=", EfxVersion.RE4)]
	public int trailStartDelay;

    [RszConditional(nameof(Version), ">=", EfxVersion.RERT)]
	public float sb_unkn1;
    public via.Color color2;
	public int unkn19;
	public int unkn20;
	public float unkn21;
	public float unkn22;
	public float unkn23;
	public float unkn24;
	public float unkn25;
	public float unkn26;
	public float unkn27;
	public float unkn28;
	public float unkn29;
    [RszConditional(nameof(Version), ">=", EfxVersion.RERT)]
	public float sb_unkn2;
	public float sb_unkn3;
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypeRibbonFollowExpression, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeTypeRibbonFollowExpression : EFXAttribute
{
	public EFXAttributeTypeRibbonFollowExpression() : base(EfxAttributeType.TypeRibbonFollowExpression) { }

	public uint unkn1_0;
	public uint unkn1_1;
	public uint unkn1_2;
	public uint unkn1_3;
	public uint unkn1_4;
	public uint unkn1_5;
	public uint unkn1_6;
	public uint unkn1_7;
    [RszConditional(nameof(Version), ">=", EfxVersion.RERT, EndAt = nameof(sb_unkn1))]
	public float sb_unkn0;
	public float sb_unkn1;
	[RszClassInstance] public EFXExpressionListWrapper expressions = new();
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypeRibbonLength, EfxVersion.RE4)]
public partial class EFXAttributeTypeRibbonLength : EFXAttribute
{
	public EFXAttributeTypeRibbonLength() : base(EfxAttributeType.TypeRibbonLength) { }

	public uint unkn1_0;
	public via.Color color0;
	public via.Color color1;
	public float unkn1_3;

	public float unkn1_4;
	public float unkn1_5;
	public float unkn1_6;
	public float unkn1_7;
	public float unkn1_8;
	public uint unkn1_9;
	public float unkn1_10;
	public float unkn1_11;
    [RszConditional(nameof(Version), ">=", EfxVersion.RERT)]
	public float sb_unkn0;
	public uint unkn1_12;
	public float unkn1_13;
	public float unkn1_14;
	public uint unkn1_15;
	public float unkn1_16;
	public float unkn1_17;
	public float unkn1_18;
	public float unkn1_19;
	public float unkn1_20;
	public float unkn1_21;
	public float unkn1_22;
	public float unkn1_23;
	public float unkn1_24;
	public float unkn1_25;

	public int unkn1_26;
	public int unkn1_27;
	public int unkn1_28;
	public float unkn1_29;

	public float unkn1_30;
	public float unkn1_31;
	public float unkn1_32;
	public float unkn1_33;
	public float unkn1_34;
	public float unkn1_35;
    [RszConditional(nameof(Version), ">=", EfxVersion.RERT, EndAt = nameof(sb_unkn2))]
	public float sb_unkn1;
	public float sb_unkn2;
    [RszConditional(nameof(Version), ">=", EfxVersion.RE4)]
	public float re4_unkn0;
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypeRibbonLengthExpression, EfxVersion.RERT, EfxVersion.RE4)]
public partial class EFXAttributeTypeRibbonLengthExpression : EFXAttribute
{
	public EFXAttributeTypeRibbonLengthExpression() : base(EfxAttributeType.TypeRibbonLengthExpression) { }

	public uint unkn1;
	public uint unkn2;
	public uint unkn3;
	public uint unkn4;
	public uint unkn5;
	public uint unkn6;
	public uint unkn7;
	public uint unkn8;
    [RszConditional(nameof(Version), ">=", EfxVersion.RERT, EndAt = nameof(sb_unkn1))]
	public uint sb_unkn0;
	public uint sb_unkn1;
    [RszConditional(nameof(Version), ">", EfxVersion.RERT, EndAt = nameof(sb_unkn7))]
	public uint sb_unkn2;
	public uint sb_unkn3;
	public uint sb_unkn4;
	public uint sb_unkn5;
	public uint sb_unkn6;
	public uint sb_unkn7;
	[RszClassInstance] public EFXExpressionListWrapper expressions = new();
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypeRibbonLightweight, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeTypeRibbonLightweight : EFXAttribute
{
	public EFXAttributeTypeRibbonLightweight() : base(EfxAttributeType.TypeRibbonLightweight) { }

	public uint unkn1;
	public via.Color color0;
	public via.Color color1;
	public float unkn2_0;
	public uint null2_1;
	public uint null2_2;
	public float unkn2_3;
	public uint unkn2_4;
	public float unkn2_5;
	public uint unkn2_6;
    [RszConditional(nameof(Version), ">=", EfxVersion.RERT)]
	public float sb_unkn0;
	public float unkn2_7;
	public uint unkn2_8;
    [RszConditional(nameof(Version), ">", EfxVersion.DMC5, EndAt = nameof(unkn2_10))]
	public float unkn2_9;
	public float unkn2_10;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypeRibbonTrail, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeTypeRibbonTrail : EFXAttribute
{
	public EFXAttributeTypeRibbonTrail() : base(EfxAttributeType.TypeRibbonTrail) { }

	public uint unkn0;
    public uint unkn1;
    public via.Color color0;
    public via.Color color1;
    public float unkn4;
    public float unkn5;
    public float unkn6;
    public float unkn7;
    public float unkn8;
    public float unkn9;
    public float unkn10;
	[RszConditional(nameof(Version), '>', EfxVersion.DMC5, EndAt = nameof(unkn12))]
    public uint unkn11;
    public uint unkn12;

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypeStrainRibbon, EfxVersion.RERT, EfxVersion.RE4)]
public partial class EFXAttributeTypeStrainRibbon : EFXAttribute, IBoneRelationAttribute
{
	public EFXAttributeTypeStrainRibbon() : base(EfxAttributeType.TypeStrainRibbon) { }

	public uint unkn1_0;
	public via.Color color0;
	public via.Color color1;
	public float unkn1_3;

	public uint null1_4;
	public uint null1_5;
	public float unkn1_6;
	public float unkn1_7;
	public float unkn1_8;
	public float unkn1_9;
	public float unkn1_10;
	public float unkn1_11;
	public uint unkn1_12;
	public float unkn1_13;
	public float unkn1_14;
	public float unkn1_15;
	public float unkn1_16;
	public float unkn1_17;
    [RszConditional(nameof(Version), ">=", EfxVersion.RERT)]
	public float sb_unkn0;

	public uint unkn1_18;
	public uint unkn1_19;
	public uint unkn1_20;
	public uint null1_21;

	public via.Color color2;
	public via.Color color3;
	public via.Color color4;
	public float unkn1_25;
	public float unkn1_26;
	public float unkn1_27;
	public float unkn1_28;
	public float unkn1_29;
	public uint unkn1_30;
	public float unkn1_31;
	public uint unkn1_32;
	public uint null1_33;
	public uint unkn1_34;
	public float unkn1_35;
	public float unkn1_36;
	public float unkn1_37;
	public float unkn1_38;
	public float unkn1_39;
	public float unkn1_40;
	public uint unkn1_41;
	public float null1_42;
	public float unkn1_43;
	public float unkn1_44;
	public float unkn1_45;
	public float unkn1_46;
	public float unkn1_47;
	public uint unkn1_48;
	public uint unkn1_49;
	public uint unkn1_50;
	public uint unkn1_51;
	public uint unkn1_52;
	public uint null1_53;
	public uint null1_54;
	public uint null1_55;
	public uint null1_56;
	public byte unkn2;
	public float null3_0;
    [RszConditional(nameof(Version), ">=", EfxVersion.RERT)]
	public float sb_unkn1;

	public float null3_1;

	public float unkn3_2;
	public float unkn3_3;
	[RszInlineWString] public string? boneName;

    public string? ParentBone { get; set; }
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknRE4Struct114, EfxVersion.RE4)]
public partial class EFXAttributeunknRE4Struct114 : EFXAttribute
{
	public EFXAttributeunknRE4Struct114() : base(EfxAttributeType.unknRE4Struct114) { }

    [RszFixedSizeArray(4)] public uint[]? unkn0;
    [RszFixedSizeArray(3)] public float[]? unkn1;
    public int unkn2;
    [RszFixedSizeArray(6)] public float[]? unkn0_rest0;
    [RszFixedSizeArray(6)] public uint[]? unkn0_rest1;
    [RszFixedSizeArray(32)] public float[]? unkn0_rest2;
    public int unkn0_rest3;
    [RszFixedSizeArray(6)] public float[]? unkn0_rest4;
	[RszInlineWString] public string? name;
	public int unkn_2_0;
	public uint unkn_2_hash;
	public uint unkn_2_mask;
	public float unkn_2_3;
	public int unkn_2_4;
	public int unkn_2_5;
	public float unkn_2_6;
}


[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypeStrainRibbonExpression, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeTypeStrainRibbonExpression : EFXAttribute
{
	public EFXAttributeTypeStrainRibbonExpression() : base(EfxAttributeType.TypeStrainRibbonExpression) { }

	public uint unkn1_0;
	public uint unkn1_1;
	public uint unkn1_2;
	public uint unkn1_3;
	public uint unkn1_4;
	public uint unkn1_5;
	public uint unkn1_6;
	public uint unkn1_7;
	public uint unkn1_8;
	public uint unkn1_9;
	public uint unkn1_10;
	public uint unkn1_11;
	public uint unkn1_12;
	public uint unkn1_13;
    [RszConditional(nameof(Version), ">=", EfxVersion.RERT, EndAt = nameof(sb_unkn1))]
	public float sb_unkn0;//;
	public float sb_unkn1;//;

	[RszClassInstance] public EFXExpressionListWrapper expressions = new();

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypeStrainRibbonMaterialExpression, EfxVersion.RE4)]
public partial class EFXAttributeTypeStrainRibbonMaterialExpression : EFXAttribute
{
	public EFXAttributeTypeStrainRibbonMaterialExpression() : base(EfxAttributeType.TypeStrainRibbonMaterialExpression) { }

	public float unkn1_0;
	public float unkn1_1;
	public float unkn1_2;
	public float unkn1_3;
	public float unkn1_4;
	public float unkn1_5;
	public float unkn1_6;
	public float unkn1_7;
	public float unkn1_8;
	public float unkn1_9;

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.UVScroll, EfxVersion.RE4)]
public partial class EFXAttributeUVScroll : EFXAttribute
{
	public EFXAttributeUVScroll() : base(EfxAttributeType.UVScroll) { }

	public uint unkn1_0;
	public float unkn1_1;
	public uint null1_2;
	public float unkn1_3;
	public float unkn1_4;
	public float unkn1_5;
	public uint null1_6;
	public float unkn1_7;
	public float unkn1_8;
	public uint null1_9;
	public uint null1_10;
	public float unkn1_11;
	public float unkn1_12;

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.UVSequence, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeUVSequence : EFXAttribute
{
	public EFXAttributeUVSequence() : base(EfxAttributeType.UVSequence) { }

	public uint null1;//<comment = "Might	 be SequenceNum">;
	public uint unkn2;//<comment = "Might be SequenceNumVariation">;
	public uint startingFrame;
	public uint startingFrameRandom;
	public float animationSpeed;
	public float animationSpeedRandom;
	public uint mode;//<comment="0 - Show only starting frame,1 - Looped Animation, 2 - Play once and disappear after last frame, 3 - Play once and stay on last frame until end of duration in Life struct.">;
	[RszInlineWString] public string? uvsPath;
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.UVSequenceModifier, EfxVersion.RE4)]
public partial class EFXAttributeUVSequenceModifier : EFXAttribute
{
	public EFXAttributeUVSequenceModifier() : base(EfxAttributeType.UVSequenceModifier) { }

	public uint unkn1_0;
	public float unkn1_1;
	public float unkn1_2;
	public float minSpeed;
	public float minSpeedRandom;
	public float maxSpeed;
	public float maxSpeedRandom;
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.UVSequenceExpression, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeUVSequenceExpression : EFXAttribute
{
	public EFXAttributeUVSequenceExpression() : base(EfxAttributeType.UVSequenceExpression) { }

    [RszFixedSizeArray(7)] public uint[]? unkn;
	[RszClassInstance] public EFXExpressionListWrapper expressions = new();
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.UnitCulling, EfxVersion.DMC5, EfxVersion.RERT, EfxVersion.RE4)]
public partial class EFXAttributeUnitCulling : EFXAttribute
{
	public EFXAttributeUnitCulling() : base(EfxAttributeType.UnitCulling) { }

	public uint unkn1_0;
	public float unkn1_1;
	public float unkn1_2;
	public float unkn1_3;
	public float unkn1_4;
	public float unkn1_5;
	public float unkn1_6;
	public float unkn1_7;
	public float unkn1_8;
	public float unkn1_9;
    [RszConditional(nameof(Version), ">", EfxVersion.DMC5)]
	public float unkn1_10;

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.VanishArea3D, EfxVersion.RE4)]
public partial class EFXAttributeVanishArea3D : EFXAttribute, IBoneRelationAttribute
{
	public EFXAttributeVanishArea3D() : base(EfxAttributeType.VanishArea3D) { }

	public uint unkn1_0;
	public uint null1_1;
	public uint unkn1_2;
	public float unkn1_3;
	public float unkn1_4;
	public float unkn1_5;
	public float unkn1_6;
	public float unkn1_7;
	public uint null1_8;
	public uint null1_9;
	public float unkn1_10;
	public uint unkn1_11;
	[RszInlineWString] public string? boneName;

    public string? ParentBone { get; set; }
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.VanishArea3DExpression, EfxVersion.RE4)]
public partial class EFXAttributeVanishArea3DExpression : EFXAttribute
{
	public EFXAttributeVanishArea3DExpression() : base(EfxAttributeType.VanishArea3DExpression) { }

	public uint unkn1_0;
	public uint unkn1_1;
	public uint unkn1_2;
	public uint unkn1_3;
	public uint unkn1_4;
	public uint unkn1_5;
	public uint unkn1_6;
	public uint unkn1_7;
	public uint unkn1_8;
	public uint unkn1_9;
	public uint unkn1_10;
	public uint unkn1_11;
	public uint unkn1_12;
	public uint unkn1_13;
	public uint unkn1_14;
	[RszClassInstance] public EFXExpressionListWrapper expressions = new();

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.VectorFieldParameter, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeVectorFieldParameter : EFXAttribute
{
	public EFXAttributeVectorFieldParameter() : base(EfxAttributeType.VectorFieldParameter) { }

	public float unkn1_0;
	public float unkn1_1;
	public float unkn1_2;
	public float unkn1_3;
	public float unkn1_4;
	public float unkn1_5;
	public float unkn1_6;
	public float unkn1_7;
	public float unkn1_8;
	public float unkn1_9;
	public float unkn1_10;
	public float unkn1_11;
	public float unkn1_12;
	public float unkn1_13;
	public float unkn1_14;
	public float unkn1_15;
	public uint null1_16;
	[RszConditional(nameof(Version), '>', EfxVersion.DMC5, EndAt = nameof(unkn1_19))]
	public uint null1_17;
	public uint unkn1_18;
	public uint unkn1_19;

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.VectorFieldParameterExpression, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeVectorFieldParameterExpression : EFXAttribute
{
	public EFXAttributeVectorFieldParameterExpression() : base(EfxAttributeType.VectorFieldParameterExpression) { }

	public uint unkn1_0;
	public uint unkn1_1;
	public uint unkn1_2;
	public uint unkn1_3;
	public uint unkn1_4;
	public uint unkn1_5;
	public uint unkn1_6;
	public uint unkn1_7;
	public uint unkn1_8;
	public uint unkn1_9;
	public uint unkn1_10;
	public uint unkn1_11;
	[RszConditional(nameof(Version), '>', EfxVersion.DMC5, EndAt = nameof(unkn1_20))]
	public uint unkn1_12;
	public uint unkn1_13;
	public uint unkn1_14;
	public uint unkn1_15;
	public uint unkn1_16;
	public uint unkn1_17;
	public uint unkn1_18;
	public uint unkn1_19;
	public uint unkn1_20;
	[RszClassInstance] public EFXExpressionListWrapper expressions = new();

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.Velocity2D, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeVelocity2D : EFXAttribute
{
	public EFXAttributeVelocity2D() : base(EfxAttributeType.Velocity2D) { }

	public float unkn1_0;
	public float unkn1_1;
	public float unkn1_2;
	public float unkn1_3;
	public float unkn1_4;

	public float unkn1_5;
	public uint null1_6;
	public uint null1_7;
	public float unkn1_8;
	public float unkn1_9;
	public uint null1_10;
	public float unkn1_11;
	public float unkn1_12;
    [RszConditional(nameof(Version), ">=", EfxVersion.RE4, EndAt = nameof(re4_unkn4))]
	public float re4_unkn0;
	public float re4_unkn1;
	public float re4_unkn2;
	public float re4_unkn3;
	public float re4_unkn4;
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.Velocity2DExpression, EfxVersion.RERT, EfxVersion.RE4)]
public partial class EFXAttributeVelocity2DExpression : EFXAttribute
{
	public EFXAttributeVelocity2DExpression() : base(EfxAttributeType.Velocity2DExpression) { }

    public uint unkn0;
    [RszFixedSizeArray(8)] public uint[]? unkn1;
    [RszConditional(nameof(Version), ">=", EfxVersion.RE4), RszFixedSizeArray(5)] public uint[]? unkn2;
	[RszClassInstance] public EFXExpressionListWrapper expressions = new();
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.Velocity3D, EfxVersion.RE4)]
public partial class EFXAttributeVelocity3D : EFXAttribute
{
	public EFXAttributeVelocity3D() : base(EfxAttributeType.Velocity3D) { }

	public uint unkn1;
	public float unkn2_0;
	public float unkn2_1;
	public float unkn2_2;
	public float unkn2_3;
	public float unkn2_4;
	public float unkn2_5;
	public float unkn2_6;
	public float unkn2_7;
	public float unkn2_8;
	public float unkn2_9;
	public float unkn2_10;
	public float unkn2_11;
	public float unkn2_12;
	public float unkn2_13;
	public float unkn2_14;
	public float unkn2_15;
	[RszConditional(nameof(Version), ">=", EfxVersion.RE4, EndAt = nameof(re4_unkn1))]
	public float re4_unkn0;
	public float re4_unkn1;

    public uint unkn3;
	public float unkn4_0;
	public float unkn4_1;
	public float unkn4_2;
	public float unkn4_3;
	public float unkn4_4;
	public float unkn4_5;

	[RszConditional(nameof(Version), ">=", EfxVersion.RERT, EndAt = nameof(sb_unkn1))]
	public float sb_unkn0;
	public float sb_unkn1;

    [RszConditional(nameof(Version), ">=", EfxVersion.RE4, EndAt = nameof(re4_unkn3))]
	public float re4_unkn2;
	public float re4_unkn3;
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.Velocity3DDelayFrame, EfxVersion.RE4)]
public partial class EFXAttributeVelocity3DDelayFrame : EFXAttribute
{
	public EFXAttributeVelocity3DDelayFrame() : base(EfxAttributeType.Velocity3DDelayFrame) { }

	public uint frameDelay;
	public uint unkn2;

}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.Velocity3DExpression, EfxVersion.RERT, EfxVersion.RE4)]
public partial class EFXAttributeVelocity3DExpression : EFXAttribute
{
	public EFXAttributeVelocity3DExpression() : base(EfxAttributeType.Velocity3DExpression) { }

	public uint unkn1_0;
	public uint indicesCount;
	public float unkn1_2;
	public float unkn1_3;
	public float unkn1_4;
	public float unkn1_5;
	public float unkn1_6;
	public float unkn1_7;
	public uint unkn1_8;
	public uint unkn1_9;
	public uint unkn1_10;
	public uint unkn1_11;
	public uint unkn1_12;

    [RszConditional(nameof(Version), ">", EfxVersion.DMC5, EndAt = nameof(re4_unkn3))]
	public uint unkn1_13;
	public uint unkn1_14;
	public uint unkn1_15;
	public uint unkn1_16;
	public uint unkn1_17;
	public uint unkn1_18;
	public uint unkn1_19;
	public uint unkn1_20;

    [RszConditional(nameof(Version), ">", EfxVersion.RERT, EndAt = nameof(sb_unkn2))]
	public uint sb_unkn0;
	public uint sb_unkn1;
	public uint sb_unkn2;

    [RszConditional(nameof(Version), ">=", EfxVersion.RE4, EndAt = nameof(re4_unkn3))]
	public uint re4_unkn0;
	public uint re4_unkn1;
	public uint re4_unkn2;
	public uint re4_unkn3;

	[RszClassInstance]
	public EFXExpressionListWrapper expressions = new();

}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknSBStruct104_NoiseExpression, EfxVersion.RE4)]
public partial class EFXAttributeunknSBStruct104_NoiseExpression : EFXAttribute
{
	public EFXAttributeunknSBStruct104_NoiseExpression() : base(EfxAttributeType.unknSBStruct104_NoiseExpression) { }

	public uint unkn1_0;
	public uint unkn1_1;
	public uint unkn1_2;
	public uint unkn1_3;
	public uint unkn1_4;
	public uint unkn1_5;
	public uint unkn1_6;
	public uint unkn1_7;
	public uint unkn1_8;
	[RszClassInstance] public EFXExpressionListWrapper expressions = new();
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknSBStruct189_PtAngularVelocity3D, EfxVersion.RE4)]
public partial class EFXAttributeunknSBStruct189_PtAngularVelocity3D : EFXAttribute
{
	public EFXAttributeunknSBStruct189_PtAngularVelocity3D() : base(EfxAttributeType.unknSBStruct189_PtAngularVelocity3D) { }

	public uint null1;
	public float null2;
	public float unkn3;
	public uint null4;
	public uint null5;
	public float null6;
	public float unkn7;
	public float unkn8;

}

//STRUCT INSERT SCRIPT STRUCT POINT <>
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknRE4Struct243_UnknGPUBillboard, EfxVersion.RE4)]
public partial class EFXAttributeunknRE4Struct243_UnknGPUBillboard : EFXAttribute
{
	public EFXAttributeunknRE4Struct243_UnknGPUBillboard() : base(EfxAttributeType.unknRE4Struct243_UnknGPUBillboard) { }

    public uint unkn0;
    public via.Color color0;
    public via.Color color1;
    public float unkn1;
    [RszFixedSizeArray(8)] public uint[]? unkn2;
    [RszFixedSizeArray(8)] public float[]? unkn3;
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknRE4Struct247_UnknTypeGPU, EfxVersion.RE4)]
public partial class EFXAttributeunknRE4Struct247_UnknTypeGPU : EFXAttribute
{
	public EFXAttributeunknRE4Struct247_UnknTypeGPU() : base(EfxAttributeType.unknRE4Struct247_UnknTypeGPU) { }

    public uint unkn0;
    public via.Color color0;
    public via.Color color1;
    public float unkn1;
    public float unkn2;
    public float unkn3;
    public float unkn4;
    public float unkn5;
    public uint unkn6;
    public uint unkn7;
    public uint unkn8;
    public uint unkn9;
    public float unkn10;
    public float unkn11;
    public float unkn12;
    public float unkn13;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknRE4Struct130, EfxVersion.RE4)]
public partial class EFXAttributeunknRE4Struct130 : EFXAttribute
{
	public EFXAttributeunknRE4Struct130() : base(EfxAttributeType.unknRE4Struct130) { }

    public int unkn0;
    [RszFixedSizeArray(10)] public float[]? unkn1;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknRE4Struct144, EfxVersion.RE4)]
public partial class EFXAttributeunknRE4Struct144 : EFXAttribute
{
	public EFXAttributeunknRE4Struct144() : base(EfxAttributeType.unknRE4Struct144) { }

    public uint unkn1;
    [RszFixedSizeArray(6)] public float[]? unkn2;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknRE4Struct58Expression, EfxVersion.RE4)]
public partial class EFXAttributeunknRE4Struct58Expression : EFXAttribute
{
	public EFXAttributeunknRE4Struct58Expression() : base(EfxAttributeType.unknRE4Struct58Expression) { }

    [RszFixedSizeArray(20)] public uint[]? unkn0;
	[RszClassInstance] public EFXExpressionListWrapper expressions = new();
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknRE4Struct244, EfxVersion.RE4)]
public partial class EFXAttributeunknRE4Struct244 : EFXAttribute
{
	public EFXAttributeunknRE4Struct244() : base(EfxAttributeType.unknRE4Struct244) { }

    [RszFixedSizeArray(15)] public uint[]? unkn;
	[RszClassInstance] public EFXExpressionListWrapper expressions = new();
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknRE4Struct210, EfxVersion.RE4)]
public partial class EFXAttributeunknRE4Struct210 : EFXAttribute
{
	public EFXAttributeunknRE4Struct210() : base(EfxAttributeType.unknRE4Struct210) { }

    public uint unkn0;
    [RszFixedSizeArray(14)] public float[]? unkn1;
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknRE4Struct150, EfxVersion.RE4)]
public partial class EFXAttributeunknRE4Struct150 : EFXAttribute
{
	public EFXAttributeunknRE4Struct150() : base(EfxAttributeType.unknRE4Struct150) { }

    public uint unkn0;
    [RszFixedSizeArray(4)] public uint[]? unkn1;
    [RszFixedSizeArray(16)] public float[]? unkn2;
    public uint unkn3;
    public uint unkn4;
    [RszFixedSizeArray(31)] public float[]? unkn5;
    [RszFixedSizeArray(7)] public uint[]? unkn6;
	public uint uvs0PathUnicodeCharCount;
	public uint uvs1PathUnicodeCharCount;
	public uint uvs2PathUnicodeCharCount;
	public uint texPathUnicodeCharCount;
	public uint uvs4PathUnicodeCharCount;
	[RszInlineWString(nameof(uvs0PathUnicodeCharCount))] public string? uvs0Path;
	[RszInlineWString(nameof(uvs1PathUnicodeCharCount))] public string? uvs1Path;
	[RszInlineWString(nameof(uvs2PathUnicodeCharCount))] public string? uvs2Path;
	[RszInlineWString(nameof(texPathUnicodeCharCount))] public string? texPath;
	[RszInlineWString(nameof(uvs4PathUnicodeCharCount))] public string? uvs4Path;
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknRE4Struct155, EfxVersion.RERT, EfxVersion.RE4)]
public partial class EFXAttributeunknRE4Struct155 : EFXAttribute
{
	public EFXAttributeunknRE4Struct155() : base(EfxAttributeType.unknRE4Struct155) { }

    public uint unkn0;
    public uint unkn1;
    public uint unkn2;
    public float unkn3;
	[RszConditional(nameof(Version), '>', EfxVersion.RERT)]
    public float unkn4;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknRE4Struct60, EfxVersion.RE4)]
public partial class EFXAttributeunknRE4Struct60 : EFXAttribute
{
	public EFXAttributeunknRE4Struct60() : base(EfxAttributeType.unknRE4Struct60) { }

    [RszFixedSizeArray(18)] public uint[]? unkn;
	[RszClassInstance] public EFXExpressionListWrapper expressions = new();
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknDD2Struct95, EfxVersion.RE4)]
public partial class EFXAttributeunknDD2Struct95 : EFXAttribute
{
	public EFXAttributeunknDD2Struct95() : base(EfxAttributeType.unknDD2Struct95) { }

    [RszFixedSizeArray(7)] public uint[]? unkn;
	[RszInlineWString] public string? uvsPath;
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknRE4Struct173, EfxVersion.RE4)]
public partial class EFXAttributeunknRE4Struct173 : EFXAttribute
{
	public EFXAttributeunknRE4Struct173() : base(EfxAttributeType.unknRE4Struct173) { }

    public uint unkn1;
    public uint unkn2;
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknRE4Struct187, EfxVersion.RE4)]
public partial class EFXAttributeunknRE4Struct187 : EFXAttribute
{
	public EFXAttributeunknRE4Struct187() : base(EfxAttributeType.unknRE4Struct187) { }

    public uint unkn;
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknRE4Struct248, EfxVersion.RE4)]
public partial class EFXAttributeunknRE4Struct248 : EFXAttribute
{
	public EFXAttributeunknRE4Struct248() : base(EfxAttributeType.unknRE4Struct248) { }

    [RszFixedSizeArray(10)] public uint[]? unkn;
	[RszClassInstance] public EFXExpressionListWrapper expressions = new();
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknRE4Struct195, EfxVersion.RE4)]
public partial class EFXAttributeunknRE4Struct195 : EFXAttribute
{
	public EFXAttributeunknRE4Struct195() : base(EfxAttributeType.unknRE4Struct195) { }

    public float unkn0;
    public float unkn1;
    public float unkn2;
    public float unkn3;
    public uint unkn4;
    public uint unkn5;
    ushort unkn6;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknRE4Struct109, EfxVersion.RE4)]
public partial class EFXAttributeunknRE4Struct109 : EFXAttribute
{
	public EFXAttributeunknRE4Struct109() : base(EfxAttributeType.unknRE4Struct109) { }

    public float unkn0;
    public float unkn1;
    public float unkn2;
    public float unkn3;
    public float unkn4;
    public float unkn5;
    public float unkn6;
    public float unkn7;
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknRE4Struct185, EfxVersion.RE4)]
public partial class EFXAttributeunknRE4Struct185 : EFXAttribute
{
	public EFXAttributeunknRE4Struct185() : base(EfxAttributeType.unknRE4Struct185) { }

    public uint unkn0;
    public float unkn1;
    public float unkn2;
    public float unkn3;
    public float unkn4;
    public float unkn5;
    public float unkn6;
    public uint unkn7;
    public uint unkn8;
    public float unkn9;
    public float unkn10;
    public float unkn11;
    public float unkn12;
    public float unkn13;
    public float unkn14;
    public float unkn15;
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknRE4Struct226, EfxVersion.RE4)]
public partial class EFXAttributeunknRE4Struct226 : EFXAttribute
{
	public EFXAttributeunknRE4Struct226() : base(EfxAttributeType.unknRE4Struct226) { }

    public uint unkn0;
    public via.Color color0;
    public via.Color color1;
    public float unkn3;
    public float unkn4;
    public float unkn5;
    public via.Color color2;
    public via.Color color3;
    public float unkn8;
    public float unkn9;
    public float unkn10;
    public float unkn11;
    public float unkn12;
    public float unkn13;
    public float unkn14;
    public float unkn15;
    public float unkn16;
    public uint unkn17;
    public float unkn18;
    public float unkn19;
    public float unkn20;
    public float unkn21;
    public float unkn22;
    public float unkn23;
    public uint unkn24;
    public float unkn25;
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknRE4Struct110, EfxVersion.RE4)]
public partial class EFXAttributeunknRE4Struct110 : EFXAttribute
{
	public EFXAttributeunknRE4Struct110() : base(EfxAttributeType.unknRE4Struct110) { }

    public uint unkn0;
    public uint unkn1;
    public uint unkn2;
    public uint unkn3;
    public uint unkn4;
    public uint unkn5;
    public uint unkn6;
    public uint unkn7;
    public uint unkn8;
    public uint unkn9;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknRE4Struct231, EfxVersion.RE4)]
public partial class EFXAttributeunknRE4Struct231 : EFXAttribute
{
	public EFXAttributeunknRE4Struct231() : base(EfxAttributeType.unknRE4Struct231) { }

    ushort unkn0;
    public uint unkn1;
    public uint unkn2;
    [RszInlineWString] public string? efcsvPath;
    [RszInlineWString] public string? unknString0;
    [RszInlineWString] public string? unknString1;
    [RszInlineWString] public string? unknString2;
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknRE4Struct197, EfxVersion.RE4)]
public partial class EFXAttributeunknRE4Struct197 : EFXAttribute
{
	public EFXAttributeunknRE4Struct197() : base(EfxAttributeType.unknRE4Struct197) { }

    public uint unkn0;
    public uint unkn1;
    public uint unkn2;
    public uint unkn3;
    public float unkn4;
    public float unkn5;
    public float unkn6;
    public float unkn7;
    public byte unkn8;
    public byte unkn9;
    public byte unkn10;
    public float unkn11;
    public float unkn12;
    public float unkn13;
    public float unkn14;
    public float unkn15;
    public float unkn16;
    public float unkn17;
    public float unkn18;
    public float unkn19;
    public byte unkn20;
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknRE4Struct184, EfxVersion.RE4)]
public partial class EFXAttributeunknRE4Struct184 : EFXAttribute
{
	public EFXAttributeunknRE4Struct184() : base(EfxAttributeType.unknRE4Struct184) { }

    public uint unkn0;
    public float unkn1;
    public float unkn2;
    public float unkn3;
    public float unkn4;
    public float unkn5;
    public float unkn6;
    public float unkn7;
    public float unkn8;
    public float unkn9;
    public float unkn10;
    public float unkn11;
    public float unkn12;
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknRE4Struct245_UnknType, EfxVersion.RE4)]
public partial class EFXAttributeunknRE4Struct245_UnknType : EFXAttribute
{
	public EFXAttributeunknRE4Struct245_UnknType() : base(EfxAttributeType.unknRE4Struct245_UnknType) { }

    public uint unkn0;
    public via.Color color0;
    public via.Color color1;
    public float unkn3;
    public float unkn4;
    public float unkn5;
    public uint unkn6;
    public uint unkn7;
    public float unkn8;
    public float unkn9;
    public float unkn10;
    public float unkn11;
    public float unkn12;
    public float unkn13;
    public float unkn14;
    public float unkn15;
    public float unkn16;
    public float unkn17;
    public float unkn18;
    public float unkn19;
    public float unkn20;
    public float unkn21;
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknRE4Struct191, EfxVersion.RE4)]
public partial class EFXAttributeunknRE4Struct191 : EFXAttribute
{
	public EFXAttributeunknRE4Struct191() : base(EfxAttributeType.unknRE4Struct191) { }

    public float unkn0;
    public float unkn1;
    public float unkn2;
    public float unkn3;
    public uint unkn4;
    public uint unkn5;
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknRE4Struct249_UnknTypeB, EfxVersion.RE4)]
public partial class EFXAttributeunknRE4Struct249_UnknTypeB : EFXAttribute
{
	public EFXAttributeunknRE4Struct249_UnknTypeB() : base(EfxAttributeType.unknRE4Struct249_UnknTypeB) { }

    public uint unkn0;
    public via.Color color0;
    public via.Color color1;
    public float unkn3;
    public float unkn4;
    public float unkn5;
    public float unkn6;
    public uint unkn7;
    public uint unkn8;
    public float unkn9;
    public float unkn10;
    public float unkn11;
    public float unkn12;
    public float unkn13;
    public uint unkn14;
    public float unkn15;
    public float unkn16;
    public uint unkn17;
    public float unkn18;
    public float unkn19;
    public float unkn20;
    public float unkn21;
    public float unkn22;
    public float unkn23;
    public float unkn24;
    public float unkn25;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.AlphaCorrection, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeAlphaCorrection : EFXAttribute
{
	public EFXAttributeAlphaCorrection() : base(EfxAttributeType.AlphaCorrection) { }

	uint unkn1;
	float unkn2_0;
	float unkn2_1;
	float unkn2_2;

}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.AngularVelocity2D, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeAngularVelocity2D : EFXAttribute
{
	public EFXAttributeAngularVelocity2D() : base(EfxAttributeType.AngularVelocity2D) { }

	uint unkn1_0;
	float unkn1_1;
	float unkn1_2;
	uint null1_3;
	uint null1_4;
	float unkn1_5;
	uint null1_6;
	uint unkn1_7;
	float unkn1_8;
	float unkn1_9;
	float unkn1_10;
	float unkn1_11;
	float unkn1_12;
	float unkn1_13;
	float unkn1_14;

}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.AngularVelocity3D, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeAngularVelocity3D : EFXAttribute
{
	public EFXAttributeAngularVelocity3D() : base(EfxAttributeType.AngularVelocity3D) { }

	uint unkn1_0;
	uint unkn1_1;
	float unkn1_2;
	float unkn1_3;
	float unkn1_4;
	float unkn1_5;
	float unkn1_6;
	float unkn1_7;
	float unkn1_8;
	float unkn1_9;
	float unkn1_10;
	float unkn1_11;
	float unkn1_12;
	float unkn1_13;
	float unkn1_14;
	float unkn1_15;
	float unkn1_16;
	float unkn1_17;
	float unkn1_18;
	float unkn1_19;

}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.AngularVelocity3DDelayFrame, EfxVersion.RERT, EfxVersion.RE4)]
public partial class EFXAttributeAngularVelocity3DDelayFrame : EFXAttribute
{
	public EFXAttributeAngularVelocity3DDelayFrame() : base(EfxAttributeType.AngularVelocity3DDelayFrame) { }

	public uint frameDelay;
	// [RszConditional(nameof(Version), ">=", EfxVersion.RE4)]
	public uint unkn1;
	// [RszFixedSizeArray(10)] public uint[]? aaaaa;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.PlayEmitter, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributePlayEmitter : EFXAttribute
{
	public EFXAttributePlayEmitter() : base(EfxAttributeType.PlayEmitter) { }

	public uint fileSize;
	[RszFixedSizeArray(nameof(fileSize))] public byte[]? efxrData;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.Distortion, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeDistortion : EFXAttribute
{
	public EFXAttributeDistortion() : base(EfxAttributeType.Distortion) { }

	public DistortionType distortionType;
	public float unkn2_strength;
	[RszConditional(nameof(Version), '>', EfxVersion.DMC5, EndAt = nameof(color))]
	public float unkn3;
	public float unkn4;
	public via.Color color;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypeRibbonChain, EfxVersion.RE4)]
public partial class EFXAttributeTypeRibbonChain : EFXAttribute
{
	public EFXAttributeTypeRibbonChain() : base(EfxAttributeType.TypeRibbonChain) { }

	public uint unkn1;
	public via.Color color0;
	public via.Color color1;
	public float unkn2_0;

	public uint null2_1;
	public uint null2_2;
	public float unkn2_3;
	public float unkn2_4;
	public float unkn2_5;
	public float unkn2_6;
	public float unkn2_7;
	public float unkn2_8;
	public float unkn2_9;
    [RszConditional(nameof(Version), ">=", EfxVersion.RERT)]
	public uint sb_unkn0;

    public float unkn2_10;
	public float unkn2_11;
	public float unkn2_12;
	public float unkn2_13;
	public float unkn2_14;
	public float unkn2_15;
	public float unkn2_16;
	public float unkn2_17;
	public uint unkn2_18;
	public float unkn2_19;
	public float unkn2_20;
	public float unkn2_21;
	[RszConditional(nameof(Version), ">=", EfxVersion.RERT)]
	public float sb_unkn1;

    public float unkn2_22;
	public float unkn2_23;
	public float unkn2_24;
	public float unkn2_25;
	public uint unkn2_26;
	public float unkn2_27;
	public uint unkn2_28;
	public float null2_29;
	public uint unkn2_30;
	public float null2_31;
	public uint unkn2_32;
	public int null2_33;
	public int unkn2_34;
	public int null2_35;
	public float unkn2_36;
	public float unkn2_37;
	public float unkn2_38;
	public float unkn2_39;
	public float unkn2_40;
	public float unkn2_41;
	public float unkn2_42;
	public float unkn2_43;
	public float unkn2_44;
	public float unkn2_45;
	public float unkn2_46;
	public float unkn2_47;
    [RszConditional(nameof(Version), ">", EfxVersion.DMC5, EndAt = nameof(re4_unkn0))]
	public float unkn2_48;
	public float unkn2_49;

    [RszConditional(nameof(Version), ">=", EfxVersion.RERT)]
	public float sb_unkn2;
    [RszConditional(nameof(Version), ">=", EfxVersion.RE4)]
	public float re4_unkn0;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.AttractorClip, EfxVersion.RE4)]
public partial class EFXAttributeAttractorClip : EFXAttribute
{
	public EFXAttributeAttractorClip() : base(EfxAttributeType.AttractorClip) { }

	public uint unkn0;//Values:[15]
	public uint null1;//Values:[0]
	public uint unkn2;//Values:[2]
	public float unkn3;//Values:[27.0, 150.0, 170.0, 298.0, 549.0]
	public uint unkn4;//Values:[4]
	public uint unkn5;//Values:[12, 16]
	public uint null6;//Values:[0]
	public uint substruct1Length;//Values:[32]
	public uint substruct2Length;//Values:[144, 192]
	public uint substruct3Length;//Values:[0]
	[RszFixedSizeArray(nameof(substruct1Length), '/', 4)] public int[]? substruct1;
	[RszFixedSizeArray(nameof(substruct2Length), '/', 4)] public int[]? substruct2;
	[RszFixedSizeArray(nameof(substruct3Length), '/', 4)] public float[]? substruct3;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.EmitterColorClip, EfxVersion.RE4)]
public partial class EFXAttributeEmitterColorClip : EFXAttribute
{
	public EFXAttributeEmitterColorClip() : base(EfxAttributeType.EmitterColorClip) { }

	public uint unkn0;//Values:[15]
	public uint null1;//Values:[0]
	public uint unkn2;//Values:[2]
	public float unkn3;//Values:[27.0, 150.0, 170.0, 298.0, 549.0]
	public uint unkn4;//Values:[4]
	public uint unkn5;//Values:[12, 16]
	public uint null6;//Values:[0]
	public uint substruct1Length;//Values:[32]
	public uint substruct2Length;//Values:[144, 192]
	public uint substruct3Length;//Values:[0]
	[RszFixedSizeArray(nameof(substruct1Length), '/', 4)] public int[]? substruct1;
	[RszFixedSizeArray(nameof(substruct2Length), '/', 4)] public int[]? substruct2;
	[RszFixedSizeArray(nameof(substruct3Length), '/', 4)] public float[]? substruct3;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.ProceduralDistortionClip, EfxVersion.RE4)]
public partial class EFXAttributeProceduralDistortionClip : EFXAttribute
{
    public EFXAttributeProceduralDistortionClip() : base(EfxAttributeType.ProceduralDistortionClip) { }

    public uint unkn0;
    public uint null1;
    public int unkn2;
    public float unkn3;
    public uint unkn4;
    public uint unkn5;
    public uint null6;
    public uint substruct1Length;
    public uint substruct2Length;
    public uint substruct3Length;
    [RszFixedSizeArray(nameof(substruct1Length), '/', 4)] public int[]? substruct1;
    [RszFixedSizeArray(nameof(substruct2Length), '/', 4)] public int[]? substruct2;
    [RszFixedSizeArray(nameof(substruct3Length), '/', 4)] public float[]? substruct3;

}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.PtColorClip, EfxVersion.RE4)]
public partial class EFXAttributePtColorClip : EFXAttribute
{
    public EFXAttributePtColorClip() : base(EfxAttributeType.PtColorClip) { }

    uint unkn0;
    uint unkn1;
    int unkn2;
    float unkn3;
    uint unkn4;
    uint unkn5;
    uint unkn6;
    uint substruct1Length;
    uint substruct2Length;
    uint substruct3Length;
    [RszFixedSizeArray(nameof(substruct1Length), '/', 4)] public int[]? substruct1;
    [RszFixedSizeArray(nameof(substruct2Length), '/', 4)] public int[]? substruct2;
    [RszFixedSizeArray(nameof(substruct3Length), '/', 4)] public float[]? substruct3;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.PtTransform3DClip, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributePtTransform3DClip : EFXAttribute
{
    public EFXAttributePtTransform3DClip() : base(EfxAttributeType.PtTransform3DClip) { }

    uint unkn0;
    uint unkn1;
    int unkn2;
    float unkn3;
    uint unkn4;
    uint unkn5;
    uint unkn6;
    uint substruct1Length;
    uint substruct2Length;
    uint substruct3Length;
    [RszFixedSizeArray(nameof(substruct1Length), '/', 4)] public int[]? substruct1;
    [RszFixedSizeArray(nameof(substruct2Length), '/', 4)] public int[]? substruct2;
    [RszFixedSizeArray(nameof(substruct3Length), '/', 4)] public float[]? substruct3;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.PtUvSequenceClip, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributePtUvSequenceClip : EFXAttribute
{
    public EFXAttributePtUvSequenceClip() : base(EfxAttributeType.PtUvSequenceClip) { }

    uint unkn0;
    uint unkn1;
    int unkn2;
    float unkn3;
    uint unkn4;
    uint unkn5;
    uint unkn6;

    uint substruct1Length;
    uint substruct2Length;
    uint substruct3Length;
    [RszFixedSizeArray(nameof(substruct1Length), '/', 4)] public int[]? substruct1;
    [RszFixedSizeArray(nameof(substruct2Length), '/', 4)] public int[]? substruct2;
    [RszFixedSizeArray(nameof(substruct3Length), '/', 4)] public float[]? substruct3;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.MeshEmitter, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeMeshEmitter : EFXAttribute
{
    public EFXAttributeMeshEmitter() : base(EfxAttributeType.MeshEmitter) { }

	public uint unkn0;
	public float unkn1;
	public uint unkn2;
	public uint unkn3;
	public uint unkn4;
	public float unkn5;
	public float unkn6;
	public float unkn7;
	[RszFixedSizeArray(10)] public uint[]? unkn8;
	public float unkn9;
	public float unkn10;
	[RszConditional(nameof(Version), '>', EfxVersion.RERT, EndAt = nameof(unkn16))]
	public uint unkn11;
	public uint unkn12;
	public uint unkn13;
	public uint unkn14;
	public float unkn15;
	public float unkn16;

    public uint mapPathLength;
    public uint meshPathLength;
    public uint mdfPathLength;
    public uint maskPathLength;
	[RszConditional(nameof(Version), '>', EfxVersion.DMC5)]
    public uint msk2PathLength;
	[RszInlineWString(nameof(mapPathLength))] public string? mapPath; // mapName: NormalRoughnessMap
	[RszInlineWString(nameof(meshPathLength))] public string? meshPath;
	[RszInlineWString(nameof(mdfPathLength))] public string? mdfPath;
	[RszInlineWString(nameof(maskPathLength))] public string? mskPath; // note: might be a path to something else; RE4 doesn't use this one at all

	[RszConditional(nameof(Version), '>', EfxVersion.DMC5), RszInlineWString(nameof(msk2PathLength))]
	public string? msk2Path; // mask - E:/mods/re4/chunks/natives/stm/_chainsaw/vfx/effecteditor/efd_character/efd_chf0/efd_chf0_rainsplash/efd_0015_chf0_rainsplash_03_body.efx.3539837 / _Chainsaw/VFX/Texture/TEX_Stage/TEX_Stage_Common/TEX_RainSplashMask/tex_0015_rainsplash_ch0a0z0_MSK1.tex
}



[RszGenerate, RszAutoReadWrite]
public partial class unknRE4Struct177_struct : BaseModel
{
	public uint unkn0;
	public uint unkn1;
	public uint hash;
	public uint unkn2;
	public uint unkn3;
	public uint unkn4;
	public uint hash2;
	public uint unkn5;
	public float unkn6;
	public uint unkn7;
	public uint unkn8;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknRE4Struct177, EfxVersion.RE4)]
public partial class EFXAttributeunknRE4Struct177 : EFXAttribute
{
    public EFXAttributeunknRE4Struct177() : base(EfxAttributeType.unknRE4Struct177) { }

	public uint unkn1;
	[RszFixedSizeArray(20)] public uint[]? unkn2;
	public int dataSize;
	[RszClassInstance, RszList(nameof(dataSize), "/ 44")] public List<unknRE4Struct177_struct> unkn5 = new();
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknRE4Struct134, EfxVersion.RE4)]
public partial class EFXAttributeunknRE4Struct134 : EFXAttribute
{
    public EFXAttributeunknRE4Struct134() : base(EfxAttributeType.unknRE4Struct134) { }

	[RszInlineWString] public string? efxPath;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknRE4Struct228, EfxVersion.RE4)]
public partial class EFXAttributeunknRE4Struct228 : EFXAttribute
{
    public EFXAttributeunknRE4Struct228() : base(EfxAttributeType.unknRE4Struct228) { }

	public uint hash1;
	public float unkn0;
	public uint hash2;
	public float unkn1;
	public float unkn2;
	public float unkn3;
	[RszFixedSizeArray(87)] public byte[]? unkn4;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.PtVelocity3DClip, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributePtVelocity3DClip : EFXAttribute
{
    public EFXAttributePtVelocity3DClip() : base(EfxAttributeType.PtVelocity3DClip) { }

    uint unkn0;
    uint unkn1;
    int unkn2;
    float unkn3;
    uint unkn4;
    uint unkn5;
    uint null6;

    uint substruct1Length;
    uint substruct2Length;
    uint substruct3Length;
    [RszFixedSizeArray(nameof(substruct1Length), '/', 4)] public int[]? substruct1;
    [RszFixedSizeArray(nameof(substruct2Length), '/', 4)] public int[]? substruct2;
    [RszFixedSizeArray(nameof(substruct3Length), '/', 4)] public float[]? substruct3;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TexelChannelOperatorClip, EfxVersion.RE4)]
public partial class EFXAttributeTexelChannelOperatorClip : EFXAttribute
{
    public EFXAttributeTexelChannelOperatorClip() : base(EfxAttributeType.TexelChannelOperatorClip) { }

    uint unkn0;
    uint null1;
    uint unkn2;
    float unkn3;
    uint unkn4;
    uint unkn5;
    uint unkn6;
    uint substruct1Length;
    uint substruct2Length;
    uint substruct3Length;
    [RszFixedSizeArray(nameof(substruct1Length), '/', 4)] public int[]? substruct1;
    [RszFixedSizeArray(nameof(substruct2Length), '/', 4)] public int[]? substruct2;
    [RszFixedSizeArray(nameof(substruct3Length), '/', 4)] public float[]? substruct3;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.Transform3DClip, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeTransform3DClip : EFXAttribute
{
    public EFXAttributeTransform3DClip() : base(EfxAttributeType.Transform3DClip) { }

	uint unkn0;
    uint null1;
    int unkn2;
    float unkn3;
    uint unkn4;
    uint unkn5;
    uint unkn6;
    uint substruct1Length;
    uint substruct2Length;
    uint substruct3Length;
    [RszFixedSizeArray(nameof(substruct1Length), '/', 4)] public int[]? substruct1;
    [RszFixedSizeArray(nameof(substruct2Length), '/', 4)] public int[]? substruct2;
    [RszFixedSizeArray(nameof(substruct3Length), '/', 4)] public float[]? substruct3;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypeMeshExpression, EfxVersion.RERT, EfxVersion.RE4)]
public partial class EFXAttributeTypeMeshExpression : EFXAttribute
{
    public EFXAttributeTypeMeshExpression() : base(EfxAttributeType.TypeMeshExpression) { }

    public uint substructCount;
    public uint substructLength;
    public uint indicesCount;
    public uint unkn4;
    public uint unkn5_0;
    public uint unkn5_1;
    public uint unkn5_2;
    public uint unkn5_3;
    public uint unkn5_4;
    public uint unkn5_5;
    public uint unkn5_6;
    public uint unkn5_7;
    public uint unkn5_8;
    public uint unkn5_9;
    public uint unkn5_10;
    public uint unkn5_11;
    public uint unkn5_12;
    public uint unkn5_13;
    public uint unkn5_14;
    public uint unkn5_15;
    public uint unkn5_16;
    public uint unkn5_17;
    public uint unkn5_18;
    public uint unkn5_19;
    public uint unkn5_20;
    public uint unkn5_21;
    public uint unkn5_22;

	[RszConditional(nameof(Version), '>', EfxVersion.RERT)]
    public uint unkn5_23;
    public uint solverSize;
	[RszConditional(nameof(Version), ">=", EfxVersion.RE4)]
    public uint unkn5_24;

	[RszConditional(nameof(Version), "<=", EfxVersion.RERT), RszFixedSizeArray(nameof(indicesCount))] public uint[]? indices;
	[RszFixedSizeArray(nameof(solverSize), '/', 4)] public uint[]? expression;
	[RszFixedSizeArray(nameof(substructLength), '/', 4)] public uint[]? substruct;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypePolygonClip, EfxVersion.RE4)]
public partial class EFXAttributeTypePolygonClip : EFXAttribute
{
    public EFXAttributeTypePolygonClip() : base(EfxAttributeType.TypePolygonClip) { }

    uint unkn0;
    uint null1;
    int unkn2;
    float unkn3;
    uint unkn4;
    uint unkn5;
    uint null6;
    uint substruct1Length;
    uint substruct2Length;
    uint substruct3Length;
    [RszFixedSizeArray(nameof(substruct1Length), '/', 4)] public int[]? substruct1;
    [RszFixedSizeArray(nameof(substruct2Length), '/', 4)] public int[]? substruct2;
    [RszFixedSizeArray(nameof(substruct3Length), '/', 4)] public float[]? substruct3;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.VectorFieldParameterClip, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributeVectorFieldParameterClip : EFXAttribute
{
    public EFXAttributeVectorFieldParameterClip() : base(EfxAttributeType.VectorFieldParameterClip) { }

    uint unkn0;
    uint null1;
    int unkn2;
    float unkn3;
    uint unkn4;
    uint unkn5;
    uint null6;
    uint substruct1Length;
    uint substruct2Length;
    uint substruct3Length;
    [RszFixedSizeArray(nameof(substruct1Length), '/', 4)] public int[]? substruct1;
    [RszFixedSizeArray(nameof(substruct2Length), '/', 4)] public int[]? substruct2;
    [RszFixedSizeArray(nameof(substruct3Length), '/', 4)] public float[]? substruct3;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.PtColliderAction, EfxVersion.DMC5, EfxVersion.RE4)]
public partial class EFXAttributePtColliderAction : EFXAttribute
{
    public EFXAttributePtColliderAction() : base(EfxAttributeType.PtColliderAction) { }

    public uint dataFlags;

    public float unkn1;
    public float unkn2;
    public uint linkedAction;

	// found in RE2RT
	[RszConditional("(dataFlags & (1 << 10)) != 0", EndAt = nameof(ukn_flag2_3))]
	public uint ukn_flag2_0; // likely some sort of shape type + data
	[RszFixedSizeArray(4)]
	public float[]? ukn_flag2_1;
	public uint ukn_flag2_2;
	[RszFixedSizeArray(5)]
	public float[]? ukn_flag2_3;

	[RszConditional("(dataFlags & (1 << 0)) != 0"), RszInlineWString]
	public string? unknString0;

	[RszConditional("(dataFlags & (1 << 1)) != 0"), RszInlineWString]
	public string? unknString1;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.PtCollision, EfxVersion.RE4)]
public partial class EFXAttributePtCollision : EFXAttribute
{
    public EFXAttributePtCollision() : base(EfxAttributeType.PtCollision) { }

    public byte stringBitFlag;//<format=binary,comment = "bitflag, determines whether there will be strings read">;
    public byte unkn0_1;
    public byte unkn0_2;
    public byte unkn0_3;
    public float unkn1;
    public float unkn2;
    public uint unkn3;
    public uint unkn4;
    public float unkn5;
    public float unkn6;
    public float unkn7;
    public float unkn8;
    public uint unkn9;
    public float unkn10;
    public float unkn11;
    public float unkn12;
    public float unkn13;
    public float unkn14;
    public float unkn15;
    public float unkn16;
	[RszConditional("(stringBitFlag & (1 << 0)) != 0"), RszInlineWString]
	public string? unknString0;

	[RszConditional("(stringBitFlag & (1 << 1)) != 0"), RszInlineWString]
	public string? unknString1;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypeMeshClip, EfxVersion.RERT, EfxVersion.RE4)]
public partial class EFXAttributeTypeMeshClip : EFXAttribute
{
    public EFXAttributeTypeMeshClip() : base(EfxAttributeType.TypeMeshClip) { }

	uint null1;
    uint unkn2;
    int unkn3;
    float unkn4;
    uint substruct1Count;
    uint substruct2Count;
    uint substruct3Count;

    uint substruct1Length;
    uint substruct2Length;
    uint substruct3Length;
	[RszConditional(nameof(Version), ">=", EfxVersion.RE4)]
    uint substruct4CountMaybe;
    uint indicesCount;

    [RszFixedSizeArray(nameof(substruct1Count))] public MeshClip_Struct1[]? substruct1;
    [RszFixedSizeArray(nameof(substruct2Count))] public MeshClip_Struct2[]? substruct2;
    [RszFixedSizeArray(nameof(substruct3Count))] public MeshClip_Struct3[]? substruct3;
    [RszFixedSizeArray(nameof(substruct1Count))] public MeshClip_Struct4[]? substruct4;
    [RszFixedSizeArray(nameof(indicesCount))] uint[]? indices;

    public struct MeshClip_Struct1
    {
        public uint unkn0;
        public uint null1;
    }

    public struct MeshClip_Struct2
    {
        public float unkn0;
        public uint null1;

		// RE3RT
        public float unkn2;
		// RE4?
        // public uint unkn2;
    }

    public struct MeshClip_Struct3
    {
		// RE3RT
        public float unkn0;
        public float null1;
        public float unkn2;
        public float unkn3;
		// RE4?
        // public float unkn0;
        // public uint null1;
        // public uint unkn2;
        // public int unkn3;
    }

    public struct MeshClip_Struct4
    {
        public uint hash;
        public uint null1;
        public uint unkn2;
        public int unkn3;
    }
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknRE4Struct213, EfxVersion.RE4)]
public partial class EFXAttributeunknRE4Struct213 : EFXAttribute
{
    public EFXAttributeunknRE4Struct213() : base(EfxAttributeType.unknRE4Struct213) { }

    public uint null1;
    public uint substruct1Count;
    public float unkn2_0;
    public uint substruct2Count;

    [RszFixedSizeArray(nameof(substruct1Count))] public unknRE4Struct213_Substruct1[]? substruct1;
    [RszFixedSizeArray(nameof(substruct2Count))] public unknRE4Struct213_Substruct2[]? substruct2;

    public struct unknRE4Struct213_Substruct1
    {
        public float unkn0;
        public float unkn1;
        public float unkn2;
        public float unkn3;
        public float unkn4;
    }

    public struct unknRE4Struct213_Substruct2
    {
        public float unkn0;
        public float unkn1;
        public float unkn2;
        public float unkn3;
        public float unkn4;
        public float unkn5;
        public float unkn6;
    }
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknSBStruct195, EfxVersion.RE4)]
public partial class EFXAttributeunknSBStruct195 : EFXAttribute
{
    public EFXAttributeunknSBStruct195() : base(EfxAttributeType.unknSBStruct195) { }

    public uint null1;
    [RszConditional(nameof(Version), ">=", EfxVersion.RE4)]
    public uint re4_unkn0;
    public float unkn2_0;
    public uint substructCount;

    [RszFixedSizeArray(nameof(substructCount))] public EFXAttributeunknSBStruct195_Substruct[]? substruct;

    public float unkn13;
    public float unkn14;
    public float unkn15;

    public struct EFXAttributeunknSBStruct195_Substruct
    {
        public float unkn0;
        public float unkn1;
        public float unkn2;
        public float unkn3;
        public float unkn4;
        public float unkn5;
        public float unkn6;
        public float unkn7;
        public float unkn11;
        public float unkn12;
        public float unkn13;
    }
}

public enum PtBehaviorPropType
{
    PropFloat = 9,
    PropFloat2 = 19,
    PropFloat3 = 11,
    PropRange = 10,
    PropUint = 4,
    PropInt = 14,
    PropPrefabpath = 17,
    PropWstring = 21,
    PropEnum = 18,
    PropColor = 15,
}

[RszGenerate, RszAutoReadWrite]
public partial class PtBehaviorVariableDataBase : BaseModel
{
	[RszIgnore] public EfxVersion Version;

	public PtBehaviorVariableDataBase(EfxVersion version) { Version = version; }

	public int unkn;
	public int size;
	[RszConditional(nameof(Version), ">=", EfxVersion.RE4, EndAt = nameof(re4_unkn1))]
	public short re4_unkn0;
	public short re4_unkn1;
}

[RszGenerate]
public partial class PtBehaviorVariableDataColor : PtBehaviorVariableDataBase
{
	public PtBehaviorVariableDataColor(EfxVersion version) : base(version) { }

	public via.Color color;
	[RszFixedSizeArray(nameof(size), - 4)] public byte[]? restData;

    protected override bool DoRead(FileHandler handler) => base.DoRead(handler) && DefaultRead(handler);
    protected override bool DoWrite(FileHandler handler) => base.DoWrite(handler) && DefaultWrite(handler);
}

[RszGenerate]
public partial class PtBehaviorVariableInteger : PtBehaviorVariableDataBase
{
	public PtBehaviorVariableInteger(EfxVersion version) : base(version) { }

	public int value;
	[RszFixedSizeArray(nameof(size), - 4)] public byte[]? restData;

    protected override bool DoRead(FileHandler handler) => base.DoRead(handler) && DefaultRead(handler);
    protected override bool DoWrite(FileHandler handler) => base.DoWrite(handler) && DefaultWrite(handler);
}
[RszGenerate]
public partial class PtBehaviorVariableFloat : PtBehaviorVariableDataBase
{
	public PtBehaviorVariableFloat(EfxVersion version) : base(version) { }

	public float value;
	[RszFixedSizeArray(nameof(size), - 4)] public byte[]? restData;

    protected override bool DoRead(FileHandler handler) => base.DoRead(handler) && DefaultRead(handler);
    protected override bool DoWrite(FileHandler handler) => base.DoWrite(handler) && DefaultWrite(handler);
}
[RszGenerate]
public partial class PtBehaviorVariableFloat2 : PtBehaviorVariableDataBase
{
	public PtBehaviorVariableFloat2(EfxVersion version) : base(version) { }

	public Vector2 Vec;
	[RszFixedSizeArray(nameof(size), - 8)] public byte[]? restData;

    protected override bool DoRead(FileHandler handler) => base.DoRead(handler) && DefaultRead(handler);
    protected override bool DoWrite(FileHandler handler) => base.DoWrite(handler) && DefaultWrite(handler);
}
[RszGenerate]
public partial class PtBehaviorVariableFloat3 : PtBehaviorVariableDataBase
{
	public PtBehaviorVariableFloat3(EfxVersion version) : base(version) { }

	public Vector3 vec;
	[RszFixedSizeArray(nameof(size), - 12)] public byte[]? restData;

    protected override bool DoRead(FileHandler handler) => base.DoRead(handler) && DefaultRead(handler);
    protected override bool DoWrite(FileHandler handler) => base.DoWrite(handler) && DefaultWrite(handler);
}

[RszGenerate]
public partial class PtBehaviorVariableDataPrefabPath : PtBehaviorVariableDataBase
{
	public PtBehaviorVariableDataPrefabPath(EfxVersion version) : base(version) { }

	[RszInlineWString(nameof(size))] public string? prefabPath;

    protected override bool DoRead(FileHandler handler) => base.DoRead(handler) && DefaultRead(handler);
    protected override bool DoWrite(FileHandler handler) => base.DoWrite(handler) && DefaultWrite(handler);
}

[RszGenerate]
public partial class PtBehaviorVariableDataPrefabUnknown : PtBehaviorVariableDataBase
{
	public PtBehaviorVariableDataPrefabUnknown(EfxVersion version) : base(version) { }

	[RszFixedSizeArray(nameof(size))] public byte[]? data;

    protected override bool DoRead(FileHandler handler) => base.DoRead(handler) && DefaultRead(handler);
    protected override bool DoWrite(FileHandler handler) => base.DoWrite(handler) && DefaultWrite(handler);
}

[RszGenerate]
public partial class PtBehaviorVariable : BaseModel
{
	[RszIgnore] public EfxVersion Version;

	public PtBehaviorVariable(EfxVersion version) { Version = version; }

	public int varSize;
	public PtBehaviorPropType dataType;
	// public uint unkn2;
	// public int dataSize;
	// [RszConditional(nameof(Version), ">=", EfxVersion.RE4, EndAt = nameof(re4_unkn1))]
	// public short re4_unkn0;
	// public short re4_unkn1;

	// TODO - possibly replaces re4_unkn0, re4_unkn1
	// if(varID == 0x0F){
	//     spos[i] = FTell();
	//     i++;
	//     via.Color small_color;
	//     char var[varSize-16];// <name="Variable", bgcolor=0xA3BECC, open=suppress>;
	// }else{
	//     char  variable[varSize-12];// <name="Vairable", bgcolor=0xD6D6D6, open=suppress>;
	// }
	[RszClassInstance, RszConstructorParams(nameof(Version)), RszSwitch(
		nameof(dataType), "==", PtBehaviorPropType.PropColor, typeof(PtBehaviorVariableDataColor),
		nameof(dataType), "==", PtBehaviorPropType.PropPrefabpath, typeof(PtBehaviorVariableDataPrefabPath),
		nameof(dataType), "==", PtBehaviorPropType.PropInt, typeof(PtBehaviorVariableInteger),
		nameof(dataType), "==", PtBehaviorPropType.PropEnum, typeof(PtBehaviorVariableInteger),
		nameof(dataType), "==", PtBehaviorPropType.PropFloat, typeof(PtBehaviorVariableFloat),
		nameof(dataType), "==", PtBehaviorPropType.PropFloat2, typeof(PtBehaviorVariableFloat2),
		nameof(dataType), "==", PtBehaviorPropType.PropFloat3, typeof(PtBehaviorVariableFloat3),
		typeof(PtBehaviorVariableDataPrefabUnknown)
	)]
	public PtBehaviorVariableDataBase? variable;

	// [RszFixedSizeArray(nameof(dataSize))] public byte[]? data;
	[RszInlineString(-1)] public string? behaviorProperty;

	protected override bool DoRead(FileHandler handler)
	{
		DefaultRead(handler);
		return true;
	}

	protected override bool DoWrite(FileHandler handler)
	{
		DefaultWrite(handler);
		return true;
	}
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.PtBehavior, EfxVersion.RE4)]
public partial class EFXAttributePtBehavior : EFXAttribute
{
    public EFXAttributePtBehavior() : base(EfxAttributeType.PtBehavior) { }

    public uint unkn1;
    public uint behaviorStringLength;
    public int varCount;
    [RszInlineString(nameof(behaviorStringLength))]
	public string? behaviorString;

	[RszClassInstance, RszList(nameof(varCount)), RszConstructorParams(nameof(Version))]
	public readonly List<PtBehaviorVariable> properties = new();
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknDD2Struct133, EfxVersion.RE4)]
public partial class EFXAttributeunknDD2Struct133 : EFXAttribute
{
	public EFXAttributeunknDD2Struct133() : base(EfxAttributeType.unknDD2Struct133) { }

    public uint unkn0;
    [RszFixedSizeArray(10)] public float[]? unkn1;
}
[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.unknDD2Struct77, EfxVersion.RE4)]
public partial class EFXAttributeunknDD2Struct77 : EFXAttribute
{
	public EFXAttributeunknDD2Struct77() : base(EfxAttributeType.unknDD2Struct77) { }

    [RszFixedSizeArray(4)] public uint[]? unkn0;
    [RszFixedSizeArray(12)] public float[]? unkn1;
}

[RszGenerate, EfxStruct(EfxAttributeType.TypeGpuMesh, EfxVersion.RE4)]
public partial class EFXAttributeTypeGpuMesh : EFXAttribute
{
    public EFXAttributeTypeGpuMesh() : base(EfxAttributeType.TypeGpuMesh) { }

    public uint unkn0;
    public uint unkn1;
    public uint unkn2;
    public uint unkn3;
    public via.Color color0;
    public via.Color color1;
    public float unkn6;
    public uint unkn7;
    public uint unkn8;
    public uint unkn9;
    public float unkn10;
    public float unkn11;
    public float unkn12;
    public uint unkn13;
    public uint unkn14;
    public uint unkn15;
    public uint unkn16;
    public uint unkn17;
    public float unkn18;
    public float unkn19;
    public float unkn20;
    public float unkn21;
    public float unkn22;
    public float unkn23;
    public float unkn24;
    public float unkn25;
    public float unkn26;
    public float unkn27;
    public float unkn28;
    public float unkn29;
    public float unkn30;
    public uint unkn31;
    public uint texCount;
    [RszInlineWString] public string? meshPath;
    [RszInlineWString] public string? unknPath;
    [RszInlineWString] public string? mdfPath;
    public uint unknDataSize;
    [RszFixedSizeArray(nameof(unknDataSize))] public byte[]? unknData;

	public int texBlockLength;
	[RszList(nameof(texCount)), RszInlineWString] public string[]? texturePaths;

	protected override bool DoRead(FileHandler handler)
    {
		DefaultRead(handler);
        return true;
    }

    protected override bool DoWrite(FileHandler handler)
    {
		texBlockLength = texturePaths?.Sum(t => (t.Length + 1) * 2) ?? 2;
		DefaultWrite(handler);
		return true;
    }
}

public enum MaterialParameterType : short
{
	MDFProperty_None = 0,
	MDFProperty_Float = 1,
	MDFProperty_Range = 2,
	MDFProperty_Texture = 3,
}

[RszGenerate, RszAutoReadWrite]
public partial class MdfProperty_RE4 : BaseModel
{
	public uint PropertyNameUTF8Hash;
	public int ukn1;
	public ushort parameterCount;
	public MaterialParameterType parameterType;

	public uint unkn2;
	[RszFixedSizeArray(16)] public byte[]? propertyValue;
}

[RszGenerate, RszAutoReadWrite, EfxStruct(EfxAttributeType.TypeMesh, EfxVersion.RERT, EfxVersion.RE4)]
public partial class EFXAttributeTypeMesh : EFXAttribute
{
    public EFXAttributeTypeMesh() : base(EfxAttributeType.TypeMesh) { }

    public byte unkn1_A;
    public byte unkn1_B;
    public byte unkn1_C;
    public byte unkn1_D;
    [RszConditional(nameof(Version), ">=", EfxVersion.RE4)]
	public uint re4_unkn0;
    public via.Color color0;
    public via.Color color1;
    public float unkn4;
    public via.Color color2;
    public float unkn6;
    public uint frameCount;
    public uint startingFrameMin;
    public uint startingFrameMax;
    public float animationSpeedMin;
    public float animationSpeedMax;
    public float acceleration;
    public float accelerationRange;
    public uint animationMode;
    public uint unkn13;
    public uint unkn14;
    public float rotationX;
    public float rotationXVariation;
    public float rotationY;
    public float rotationYVariation;
    public float rotationZ;
    public float rotationZVariation;
    public float scaleX;
    public float scaleXVariation;
    public float scaleY;
    public float scaleYVariation;
    public float scaleZ;
    public float scaleZVariation;
    public float scaleMultiplier;
    public float scaleMultiplierVariation;
    public uint unkn23;
    public uint unkn24;
    [RszConditional(nameof(Version), ">=", EfxVersion.RE4)]
    public uint re4_unkn1;
    public uint texCount;
    [RszInlineWString] public string? meshPath;
    [RszInlineWString] public string? unknPath;
    [RszInlineWString] public string? mdfPath;

	[RszConditional(nameof(texCount), "!=", 0, EndAt = nameof(properties))]
	public uint propertiesDataSize;
	[RszClassInstance, RszList(nameof(propertiesDataSize), '/', 32)]
	public readonly List<MdfProperty_RE4> properties = new();

	public int texPathBlockLength;
	[RszInlineWString, RszList(nameof(texCount))] public string[]? texPaths;

	[RszConditional(nameof(texCount), "==", 0, EndAt = nameof(substruct))]
	public uint mdfPropertyHash;
	[RszFixedSizeArray(nameof(texPathBlockLength), '/', 4)] public uint[]? substruct;
}

