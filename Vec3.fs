namespace Raytracer

type Vec3 = struct
    val X: float
    val Y: float
    val Z: float
    
    new (x, y, z) = {X = x; Y = y; Z = z}
end

module Vector = 

    let add = fun (v1:Vec3) (v2:Vec3) -> new Vec3(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z)

    let subtract = fun (v1:Vec3) (v2:Vec3) -> new Vec3(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z)

    let scale = fun (v:Vec3) (n) -> new Vec3(v.X * n, v.Y * n, v.Z * n)

