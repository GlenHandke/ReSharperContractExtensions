using System.Diagnostics.Contracts;
using System;

[ContractClass(typeof(AContract))]
abstract class A
{
  public abstract void EnabledOnAbstractMethod(string s{caret});
}

[ContractClassFor(typeof(A))]
abstract class AContract : A
{
  public override void EnabledOnAbstractMethod(string s)
  {
  }
}