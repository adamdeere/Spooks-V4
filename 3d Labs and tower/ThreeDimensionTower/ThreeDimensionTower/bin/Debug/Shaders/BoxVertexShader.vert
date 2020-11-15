#version 330
uniform mat4 uView;
uniform mat4 uProjection;
uniform mat4 uModel;

uniform vec3 uLightDirection;
uniform sampler2D normalMap;

in vec3 boxVertexPosition;
in vec2 vTexCoords;
in vec3 vColour; 


out vec2 boxTexCoords;
out vec4 oSurfacePosition;
out vec4 oNormal;
out vec3  oboxVertexPosition;

void main()
{
    vec3 normalfromTexture = texture2D(normalMap, vTexCoords).xyz;
	vec3 normal = normalize(2.0 * normalfromTexture - 1.0);
	gl_Position = vec4(boxVertexPosition, 1)  * uModel * uView * uProjection;
    boxTexCoords = vTexCoords; 
	oboxVertexPosition = boxVertexPosition;
	vec3 inverseTransposeNormal = normalize(normal * mat3(transpose(inverse(uModel * uView)))); 
	// oSurfacePosition = vec4(boxVertexPosition, 1) * uModel * uView; 
	 oNormal = vec4(normalize(normal * mat3(transpose(inverse(uModel * uView)))), 1);
}