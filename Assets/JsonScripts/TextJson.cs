using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
public class TextJson : MonoBehaviour
{
    private string Json;
    /// <summary>
    /// 创建Json对象，方法1
    /// </summary>
    private void CreateJson()
    {
        JsonWriter json = new JsonWriter();
        json.WriteObjectStart();

        json.WritePropertyName("name");
        json.Write("张三");
        json.WritePropertyName("level");
        json.Write("1");
        json.WritePropertyName("job");
        json.Write("法师");
        json.WritePropertyName("exp");
        json.Write(1.1);

        json.WriteObjectEnd();
        Json  = json.ToString();
    }

    private string Json2;
    /// <summary>
    /// 方法2
    /// </summary>
    private void CreateLitJson()
    {
        JsonData json = new JsonData();
        json["name"] = "张三";
        json["level"] = 1;
        Json2 = json.ToJson();
    }
    /// <summary>
    /// 解析Json
    /// </summary>
    private void ParsingJson()
    {
        JsonData json = JsonMapper.ToObject(Json2);
        int a = int.Parse(json["level"].ToString());
        
        
    }
}
