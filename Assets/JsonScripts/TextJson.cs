using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
public class TextJson : MonoBehaviour
{
    private string Json;
    /// <summary>
    /// ����Json���󣬷���1
    /// </summary>
    private void CreateJson()
    {
        JsonWriter json = new JsonWriter();
        json.WriteObjectStart();

        json.WritePropertyName("name");
        json.Write("����");
        json.WritePropertyName("level");
        json.Write("1");
        json.WritePropertyName("job");
        json.Write("��ʦ");
        json.WritePropertyName("exp");
        json.Write(1.1);

        json.WriteObjectEnd();
        Json  = json.ToString();
    }

    private string Json2;
    /// <summary>
    /// ����2
    /// </summary>
    private void CreateLitJson()
    {
        JsonData json = new JsonData();
        json["name"] = "����";
        json["level"] = 1;
        Json2 = json.ToJson();
    }
    /// <summary>
    /// ����Json
    /// </summary>
    private void ParsingJson()
    {
        JsonData json = JsonMapper.ToObject(Json2);
        int a = int.Parse(json["level"].ToString());
        
        
    }
}
