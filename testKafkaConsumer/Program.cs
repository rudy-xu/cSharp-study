using System;
using System.Threading;
using Confluent.Kafka;

class Program
{
    public static void Main(string[] args)
    {
        var conf = new ConsumerConfig
        { 
            GroupId = "test",
            BootstrapServers = "10.86.12.127:9092,10.86.12.127:9093,10.86.12.127:9094",
            AutoOffsetReset = AutoOffsetReset.Earliest,
            // Note: The AutoOffsetReset property determines the start offset in the event
            // there are not yet any committed offsets for the consumer group for the
            // topic/partitions of interest. By default, offsets are committed
            // automatically, so in this example, consumption will only start from the
            // earliest message in the topic 'my-topic' the first time you run the program.
            AutoCommitIntervalMs = 1000,
            EnableAutoCommit = true
        };

        //ConsumerBuilder<Tkey,TValue> 初始化一个ConsumerBuilder实例(用于构建消费者)
        //Ignore是一个sealed类(有点类似与枚举)，使得消息key或者value可以为空值
        using (var consumer = (new ConsumerBuilder<Ignore, string>(conf)).Build())
        {
            consumer.Subscribe("mykafka0520");

            CancellationTokenSource cts = new CancellationTokenSource();    //向应该被取消的CancellationToken发送信号

            //截获按下Ctrl+C组合键信号，以便时间除了程序可以决定是继续执行还是终止
            Console.CancelKeyPress += (_, e) => {
                e.Cancel = true; // prevent the process from terminating.
                cts.Cancel();    //cancel request
            };

            try
            {
                Console.WriteLine("-----------------------Prepared to receive message---------------------");
                while (true)
                {
                    try
                    {
                        //pull for new messages/events  (Token--获取CancellationToken)
                        var records = consumer.Consume(cts.Token);
                        Console.WriteLine($"Consumed message '{records.Message.Value}' at: '{records.TopicPartitionOffset}'.");
                    }
                    catch (ConsumeException e)
                    {
                        Console.WriteLine($"Error occured: {e.Error.Reason}");
                    }
                }
            }
            catch (OperationCanceledException)
            {
                // Ensure the consumer leaves the group cleanly and final offsets are committed.
                consumer.Close();
            }
        }
    }
}


//--------------------------------------------------------------------------------------------------------
// using System;
// using System.Text;
// using System.Collections.Generic;
// using Confluent.Kafka;
// using Confluent.Kafka.Serialization;

// public class testKafka
// {
//   public static void Main()
//   {
//     var conf = new Dictionary<string, object> 
//     { 
//       { "group.id", "test" },
//       { "bootstrap.servers", "10.86.12.120:9092,10.86.12.120:9093,10.86.12.120:9094" },
//       { "auto.commit.interval.ms", 1000 },
//       { "auto.offset.reset", "earliest" }
//     };

//     using (var consumer = new Consumer<Null, string>(conf, null, new StringDeserializer(Encoding.UTF8)))
//     {
//       consumer.OnMessage += (_, msg)
//         => Console.WriteLine($"Read '{msg.Value}' from: {msg.TopicPartitionOffset}");

//       consumer.OnError += (_, error)
//         => Console.WriteLine($"Error: {error}");

//       consumer.OnConsumeError += (_, msg)
//         => Console.WriteLine($"Consume error ({msg.TopicPartitionOffset}): {msg.Error}");

//       consumer.Subscribe("mykafka0512");

//       while (true)
//       {
//         consumer.Poll(TimeSpan.FromMilliseconds(100));
//       }
//     }
//   }
// }