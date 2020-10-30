﻿using System.Collections;

namespace UTJ.ProfilerReader.BinaryData.Stats
{
    public partial class AllProfilerStats
    {

        internal void Read_0x20160622(System.IO.Stream stream)
        {
            this.memoryStats = new MemoryStats();
            this.drawStats = new DrawStats();
            this.physicsStats = new PhysicsStats();
            this.physics2DStats = new Physics2DStats();
            this.networkOperationStats = new NetworkOperationStats();
            this.networkMessageStats = new NetworkMessageStats();
            this.debugStats = new DebugStats();
            this.audioStats = new AudioStats();
            this.chartSample = new ChartSample();
            this.chartSampleSelected = new ChartSample();

            memoryStats.Read_0x20160622(stream);
            drawStats.Read_0x20160622(stream);
            physicsStats.Read_0x20160622(stream);
            physics2DStats.Read_0x20160622(stream);
            networkOperationStats.Read_0x20160622(stream);
            networkMessageStats.Read_0x20160622(stream);
            debugStats.Read_0x20160622(stream);
            audioStats.Read_0x20160622(stream);
            chartSample.Read_0x20160622(stream);
            chartSampleSelected.Read_0x20160622(stream);
        }
    }
}