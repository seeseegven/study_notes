##### <font size=6>1.用Shader "ShaderName"来为shader命名。例如`Shader "Custom/Myshader"`表示在Shader的Custom的MyShader路径。

##### <font size=6>2.Properties语句块如下
<font size=5>

    Properties {
        Name ("display name", PropertyType) = DefaultValue
        Name ("display name", PropertyType) = DefaultValue
    }
##### Name是属性的名字。display name是显示在材质面板上的名字。每个属性都要指定类型。每个属性也要赋一个默认值。

|属性类型|默认值定义语法|       例子      |
|-------|-------------|-----------------|
|Int    |number       |_Int("Int",Int)=2|
|Float  |number       |_Float("Float", Float)=1.5|
|Range(min,max)|number|_Range("Range",Range(0.0,5.0)=3.0)
|Color|(num,num,num,num)|_Color("Color", Color)=(1,1,1,1)|
|Vector|(n,n,n,n)|_Vector("Vector",Vector)=(2,6,3,1)|
|2D|"文本"{}|_2D("2D",2D)=""{}|
|Cube|"文本"{}|_Cube("Cube",Cube)="white"{}|
|3D|"defaulttexture"{}|_3D("3D",3D)="black"{}|

##### <font size=6>3.SubShader
##### <font size=6>每个Unity Shader都至少要包含一个SubShader与一块，主要是为了适配不同的硬件。
<font size=5>

    SubShader {
        //可选的
        [Tags]

        //可选的
        [RenderSetup]

        Pass{}        
    }
<font size=6>标签设置和Pass中的标签设置不同，而状态设置是相同的。
<font size=4>

|状态名称|设置指令|解释|
|-------|-------|----|
|Cull|Cull Back//Front/Off|剔除背面，正面，关闭剔除|
|ZTest|ZTest Less Greater/LEqual/GEqual/Equal/NotEqual/Always|设置深度测试函数|
|ZWrite|ZWrite On/Off|开启/关闭深度写入|
|Blend|Blend SrcFactor DstFactor|开启并设置混合模式|

<font size=6>[Tags]是字符串类型的键值对，`Tags {"TagName1" = "Value1" "TagName2" = "Value2"}`，以下是subshader中的标签
<font size=4>

|标签类型|说明|例子|
|-------|----|---|
|Queue|控制渲染顺序，指定渲染队列|Tags {"Queue"="Transparent"}|
|RenderType|对着色器分类|Tags{"RenderType"="Opaque"}|
|DisableBatching|是否使用批处理|Tags{"DisableBatching"="True"}|
|ForceNoShadowCasting|是否使用投射阴影|Tags{"ForceNoShadowCasting"="True"}|
|IgnoreProjector|如果不受Projector的影响，通常用于半透明物体|Tags{"IgnoreProjector"="True"}|
|CanUseSpriteAtlas|False是用于精灵|Tags{"CanUseSpriteAtlas"="False"}|
|PreviewType|材质预览类型|Tags{"PreviewType"="Plane"}|

<font size=4>

    Pass {
        [Name]
        [Tags]
        [RenderSetup]
    }
<font size=6>**`Name "MyPassName"`**来命名，命名后可以使用`UsePass "PASSNAME"`来直接使用其他Unity Shader中的Pass，PASSNAME必须全大写
<font size=4>

|Pass的标签类型|说明|例子|
|-------------|----|----|
|LightMode|定义该Pass在渲染流水线的角色|Tags{"LightMode"="ForwardBase"}|
|RequireOptions|满足要求时渲染该Pass|Tags{"RequireOptions"="SoftVegetation"}|

##### <font size=6>4.Fallback
<font size=6>类似于case语句的default。语法如下：`Fallback "name"`或`Fallback Off`。