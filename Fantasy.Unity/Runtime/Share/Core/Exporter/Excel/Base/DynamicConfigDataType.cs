#if FANTASY_NET
using System.Reflection;
using System.Text;

namespace Fantasy.Core;

public class DynamicConfigDataType
{
    public AProto ConfigData;
    public Type ConfigDataType;
    public Type ConfigType;
    public MethodInfo Method;
    public object Obj;
    public StringBuilder Json = new StringBuilder();
}
#endif
