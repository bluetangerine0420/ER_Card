using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class CommandExecutor
    {
    private Queue<ICommand> m_commandQueue;

    public void AddCommand(ICommand pCommand)
    {
        m_commandQueue.Enqueue(pCommand);
    }

    public void Execute()
    {
        while (m_commandQueue.TryDequeue(out var command))
        {
            command.Execute();
        }
    }
}

