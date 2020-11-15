#version 330

in vec2 boxTexCoords;
in vec3 oboxVertexPosition;

out vec4 FragColour;

uniform sampler2D baseMap;
uniform float pixelSize;
uniform vec4 glowColour;
uniform float intentsity;


vec4 texSmoothing(sampler2D Texture0, vec2 uv)
{
		vec4 smoothedCol=vec4(1.0);
		for (int i=-2; i<=2; i++)
		{
			for (int j=-2; j<=2; j++)
			{
				smoothedCol += texture2D(Texture0, uv + vec2(i, j)* pixelSize);
			}
		}
			return smoothedCol/35.0;
}


void main()
{
   vec4 teapotSmoothed=texSmoothing(baseMap, boxTexCoords);
   vec4 teapot = texture2D(baseMap, boxTexCoords);
   if(teapot.x > 0.1)
      FragColour=texture2D(baseMap, boxTexCoords);
   else
   FragColour =teapotSmoothed * glowColour * intentsity; 
} 